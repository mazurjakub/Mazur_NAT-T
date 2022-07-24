using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Open.Nat;
using System.Text;
using System.IO;

namespace Mazur_NAT_T.Forms
{
    public partial class FormHolePunching : Form
    {

        public static IPEndPoint ServerEndPoint = new IPEndPoint(IPAddress.Parse("3.143.208.24"), 1700);
        public static UdpClient server = new UdpClient();
        public static UdpClient connectedClient = new UdpClient();
        public static Socket socket = new Socket(AddressFamily.Unspecified, SocketType.Dgram, ProtocolType.Udp);

        public static bool hasSecondClient = false;
        public static string secondClientIP;
        public static string secondClientPort;
        public FormHolePunching()
        {
            InitializeComponent();
        }

        private void FormHolePunching_Load(object sender, EventArgs e)
        {
            try
            {
                //Setting up UDP socket and connecting to server endpoint
                server.AllowNatTraversal(true);
                server.ExclusiveAddressUse = false;
                server.Client.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                server.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                server.Connect(ServerEndPoint);

                //Start recieving data from server
                Thread ThreadListen = new Thread(() => ReceiveDataFromEP(ServerEndPoint, server));
                ThreadListen.IsBackground = true;
                ThreadListen.Start();
            }
            catch
            {
                WriteToLabel("Chyba při připojení k serveru.");
            }
        }



        private async Task ConnectToServer()
        {
            try
            {
                string key = txtBoxKey.Text;
                txtBoxKey.Text = "";
                SendDataToServer(key, server);

                WriteToLabel("Pro vymazání záznamu ze serveru, zadejte klíč '0'.\n");

                await Task.Run(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        if (hasSecondClient) break;
                    }
                }
                );
                

                Thread.Sleep(100);
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Parse(secondClientIP), 53);

                connectedClient.AllowNatTraversal(true);
                connectedClient.Client.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                connectedClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                connectedClient.Connect(clientEndPoint);

                hasSecondClient = false;
                Thread thread = new Thread(() => ReceiveDataFromEP(clientEndPoint, connectedClient));
                thread.Start();

                await Task.Run(() =>
                {
                    while (true)
                    {
                        try
                        {

                            SendDataToServer("Hello", connectedClient);
                            Thread.Sleep(1000);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                });
                
            }
            catch(Exception e)
            {
                WriteToLabel("\nNepodařilo se pripojit: " + e.Message);
                return;
            }

        }

        //Sends string to connected server (ServerEndPoint)
        public void SendDataToServer(string dataToSend, UdpClient receiver)
        {
            try
            {
                int byteCount = Encoding.ASCII.GetByteCount(dataToSend);
                byte[] sendData = Encoding.ASCII.GetBytes(dataToSend);
                receiver.Send(sendData, byteCount);
            }
            catch (Exception e)
            {
                WriteToLabel("Chyba při odesílání: " + e.Message);
                return;
            }

        }


        public void ReceiveDataFromEP(IPEndPoint endPoint, UdpClient sender)
        {
            while (!hasSecondClient)
            {
                byte[] receivedData;
                receivedData = sender.Receive(ref endPoint);

                string request = Encoding.UTF8.GetString(receivedData);


                WriteToLabel("Prichozi zprava z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                WriteToLabel("Obsah zpravy: " + request + "\n");
                   

                // If server sends IP address, initiate connection to that IP
                if (IsIPAddress(request) && !hasSecondClient)
                {
                    secondClientIP = request;
                    hasSecondClient = true;
                    receivedData = null;

                    receivedData = server.Receive(ref endPoint);
                    request = Encoding.UTF8.GetString(receivedData);

                    WriteToLabel("Prichozi zprava z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                    WriteToLabel("Obsah zpravy: " + request + "\n");

                    secondClientPort = request;
                }
            }
        }


        // From https://stackoverflow.com/questions/7461080/fastest-way-to-check-if-string-contains-only-digits-in-c-sharp
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        //From https://morgantechspace.com/2016/01/check-string-is-ip-address-in-c-sharp.html
        public static bool IsIPAddress(string ipAddress)
        {
            bool retVal = false;

            try
            {
                IPAddress address;
                retVal = IPAddress.TryParse(ipAddress, out address);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retVal;
        }

        public void WriteToLabel(string str)
        {
            if (lblOutput.InvokeRequired)
            {
                Action writeSafe = delegate { WriteToLabel($"{str}"); };
                lblOutput.Invoke(writeSafe);
            }
            else
            {
                lblOutput.Text += "\n" + str;
                lblOutput.Refresh();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtBoxKey.Text == "" || !IsDigitsOnly(txtBoxKey.Text))
            {
                MessageBox.Show("Klíč nesmí být prázdný a musí obsahovat pouze číslice!");
                return;
            }
            else if (txtBoxKey.Text == "0")
            {
                SendDataToServer("0", server);
            }
            _ = ConnectToServer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
