using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Open.Nat;

namespace Mazur_NAT_T.Forms
{
    public partial class FormPortMapping : Form
    {
        public FormPortMapping()
        {
            InitializeComponent();
        }

        private void FormPortMapping_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        private async Task CreateMappingAsync()
        {
            string mappingName = txtBoxPortName.Text,
                extPortText = txtBoxExternalPort.Text,
                intPortText = txtBoxInternalPort.Text;

            // check if ports are numbers
            if(!(int.TryParse(extPortText, out int extPort))){
                MessageBox.Show("Neplatný externí port");
                return;
            }

            if(!(int.TryParse(intPortText, out int intPort)))
            {
                MessageBox.Show("Neplatný interní port");
                return;
            }
            try
            {
                var discoverer = new NatDiscoverer();

                // using SSDP protocol, it discovers NAT device.
                var device = await discoverer.DiscoverDeviceAsync();

                // display the NAT's IP address
                Console.WriteLine("Externí IP adresa je: {0} ", await device.GetExternalIPAsync());

                // create a new mapping in the router [external_ip:extPort -> host_machine:intPort]
                await device.CreatePortMapAsync(new Mapping(Protocol.Tcp, intPort, extPort, mappingName));

                // configure a TCP socket listening on intPort
                var endPoint = new IPEndPoint(IPAddress.Any, intPort);
                var socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                socket.Bind(endPoint);
                socket.Listen(4);
            }

            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }

            // catching mapping errors
            catch(MappingException me)
            {
                switch (me.ErrorCode)
                {
                    case 718:
                        MessageBox.Show("Externí port je již využíván.");
                        break;

                    case 728:
                        MessageBox.Show("Mapovací tabulka routeru je plná.");
                        break;
                }
            }

        }

        private async Task ListMappings()
        {
            var nat = new NatDiscoverer();

            // we don't want to discover forever, just 5 senconds or less
            var cts = new CancellationTokenSource(5000);

            // we are only interested in Upnp NATs because PMP protocol doesn't allow to list mappings
            var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

            foreach (var mapping in await device.GetAllMappingsAsync())
            {
                Console.WriteLine(mapping);
            }
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            _ = CreateMappingAsync();
            
        }
    }
}
