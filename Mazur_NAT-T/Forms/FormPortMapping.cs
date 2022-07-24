using System;
using System.Net;
using System.Net.Sockets;
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


        private async Task CreateMappingAsync()
        {
            string mappingName = txtBoxMappingName.Text,
                extPortText = txtBoxExternalPort.Text,
                intPortText = txtBoxInternalPort.Text;

            // Check if ports are numbers and if they are in registered port range
            if(!(int.TryParse(extPortText, out int extPort)) && extPort < 1024 && extPort > 49151){
                MessageBox.Show("Neplatný externí port");
                return;
            }

            if(!(int.TryParse(intPortText, out int intPort)) && intPort < 1024 && intPort > 49151)
            {
                MessageBox.Show("Neplatný interní port");
                return;
            }
            try
            {
                // Discover mappings
                var discoverer = new NatDiscoverer();

                // Using SSDP protocol to discover NAT device.
                var device = await discoverer.DiscoverDeviceAsync();

                // Create a new mapping in the router [NAT_device_IP:external_port -> host_machine_IP:internal_port].
                var mapping = new Mapping(Protocol.Tcp, intPort, extPort, mappingName);
                await device.CreatePortMapAsync(mapping);

                // Display created mapping
                lblMapOutput.Text = "Vytvořeno mapování: " + await device.GetExternalIPAsync() + ":" + extPort
                        + " -> " + mapping.PrivateIP + ":" + intPort;

                // Configure a TCP socket to listen on internal port
                var endPoint = new IPEndPoint(IPAddress.Any, intPort);
                var socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                socket.Bind(endPoint);
                socket.Listen(4);
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }

            // Catching mapping errors
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
            try
            {
                // Discover mappings
                var nat = new NatDiscoverer();

                // Stop discovering after 5 seconds
                var cts = new CancellationTokenSource(5000);

                // Discover UPnP NAT device
                var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                lblMappings.Text = "";

                // Write each mapping's information "mapping_name: NAT_device_IP:external_port -> host_machine_IP:internal_port"
                foreach (var mapping in await device.GetAllMappingsAsync())
                {
                    lblMappings.Text += "  " + mapping.Description + ": " + await device.GetExternalIPAsync() + ":" + mapping.PublicPort + " -> "
                        + mapping.PrivateIP + ":" + mapping.PrivatePort + "\n";
                }
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }
        }

        // Delete mapping using name of the mapping
        private async Task DeleteMapping()
        {
            try
            {
                // Discover mappings
                var nat = new NatDiscoverer();

                // Stop discovering after 5 seconds
                var cts = new CancellationTokenSource(5000);

                // Discover UPnP NAT device
                var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                string mappingName = txtBoxDeleteMappingName.Text;
                lblDeleteOutput.Text = "";

                // Compare each mapping name with given name, if they match, delete the mapping
                foreach (var mapping in await device.GetAllMappingsAsync())
                {
                    if (mapping.Description.Contains(mappingName))
                    {
                        lblDeleteOutput.Text = "Odstraňuji: " + mappingName;
                        lblDeleteOutput.Refresh();
                        await device.DeletePortMapAsync(mapping);
                    }
                }

                if (lblDeleteOutput.Text == "")
                {
                    lblDeleteOutput.Text = "Nenalezeno mapování s názvem: " + mappingName;
                    lblDeleteOutput.Refresh();
                }
                await Task.Delay(2000);
                lblDeleteOutput.Text = "";
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            _ = CreateMappingAsync();
            
        }

        private void btnShowMappings_Click(object sender, EventArgs e)
        {
            _ = ListMappings();
        }

        private void btnDeleteMapping_Click(object sender, EventArgs e)
        {
            _ = DeleteMapping();
        }
    }
}
