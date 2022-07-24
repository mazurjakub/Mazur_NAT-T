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
        public Thread ThreadListen;

        public FormHolePunching()
        {
            InitializeComponent();
            FormClosing += FormHolePunching_Closing;
        }


        private void FormHolePunching_Load(object sender, EventArgs e)
        {
            try
            {
                lblOutput.Text = FormHlaniMenu.lblHolep;
                lblOutput.Refresh();

                //Start recieving data from server
                ThreadListen = new Thread(() => ReceiveDataFromEP(ServerEndPoint, server));
                ThreadListen.IsBackground = true;

                ThreadListen.Start();

                if (!FormHlaniMenu.alreadyLoaded)
                {
                    FormHlaniMenu.alreadyLoaded = true;
                    //Setting up UDP socket and connecting to server endpoint
                    server.AllowNatTraversal(true);
                    server.ExclusiveAddressUse = false;
                    server.Client.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                    server.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    server.Connect(ServerEndPoint);
                }
            }
            catch (Exception exp)
            {
                WriteToLabel("Chyba při připojení k serveru." + exp.Message);
            }
        }

        private void FormHolePunching_Closing(object sender, FormClosingEventArgs e)
        {
            ThreadListen.Abort();
        }

        private async Task ConnectToClient()
        {
            try
            {
                IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Parse(secondClientIP), int.Parse(secondClientPort));

                connectedClient.AllowNatTraversal(true);
                connectedClient.Client.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                connectedClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                connectedClient.Connect(clientEndPoint);

                hasSecondClient = false;
                Thread thread = new Thread(() => ReceiveDataFromEP(clientEndPoint, connectedClient));
                thread.Start();

                SendDataToServer("Hello", connectedClient);

            }
            catch (Exception e)
            {
                WriteToLabel("\nNepodařilo se připojit: " + e.Message);
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

                WriteToLabel("\n");
                WriteToLabel("Příchozi zpráva z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                WriteToLabel("Obsah zprávy: " + request + "\n");


                // If server sends IP address, initiate connection to that IP
                if (IsIPAddress(request) && !hasSecondClient)
                {
                    secondClientIP = request;
                    hasSecondClient = true;
                    receivedData = server.Receive(ref endPoint);
                    request = Encoding.UTF8.GetString(receivedData);

                    WriteToLabel("\n");
                    WriteToLabel("Příchozí zpráva z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                    WriteToLabel("Obsah zprávy: " + request + "\n");
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
                retVal = IPAddress.TryParse(ipAddress, out IPAddress address);
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
                lblOutput.AppendText(Environment.NewLine);
                lblOutput.AppendText(str);
                lblOutput.Refresh();
                FormHlaniMenu.lblHolep = lblOutput.Text;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtBoxKey.Text == "" || !IsDigitsOnly(txtBoxKey.Text))
            {
                MessageBox.Show("Klíč nesmí být prázdný a musí obsahovat pouze číslice!");
                return;
            }
            else if (txtBoxKey.Text == "0")
            {
                SendDataToServer("0", server);
                txtBoxKey.Text = "";
                return;
            }
            else if (FormHlaniMenu.isFirstMessage)
            {
                FormHlaniMenu.isFirstMessage = false;
                lblOutput.Text = "Pro vymazání záznamu ze serveru, zadejte klíč '0'.";
                SendDataToServer(txtBoxKey.Text, server);
                txtBoxKey.Text = "";
                txtBoxKey.Refresh();
            }
            else
            {
                SendDataToServer(txtBoxKey.Text, server);
                txtBoxKey.Text = "";
                txtBoxKey.Refresh();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void isClientConnected_Tick(object sender, EventArgs e)
        {
            if (hasSecondClient)
            {
                _ = ConnectToClient();
            }
        }
    }
}
