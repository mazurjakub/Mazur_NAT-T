using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace Mazur_NAT_T
{
    public partial class FormHlaniMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public static bool alreadyLoaded = false;
        public static bool isFirstMessage = true;
        public static string lblHolep = "Okno pro komunikaci se serverem a klientem";

        public static IPEndPoint ServerEndPoint = new IPEndPoint(IPAddress.Parse("3.143.208.24"), 1700);
        public static UdpClient server = new UdpClient();
        public static UdpClient connectedClient = new UdpClient();
        public static Socket socket = new Socket(AddressFamily.Unspecified, SocketType.Dgram, ProtocolType.Udp);

        public FormHlaniMenu()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;

        }
        //Metody


        /* Metoda na zvýraznění tlačítka, které bylo zakliknuto
         *
         *1) Změní se barva pozadí tlačítka
         *2) Změní se barva fontu tlačítka
         *3) Změní se velikost fontu
         *
         */

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;

                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    currentButton.BackColor = Color.FromArgb(0, 134, 212);

                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 111, 173);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        /*
         * Metoda otevře a nastaví v panelu jednotlivé formy
         * 
         * 1. Zkontroluje, jestli není otevřená nějaká ChildForma (pokud ano, zavře ji)
         * 2. Nastaví ChildFormu na aktivní formu
         * 3. Nastaví vlastnosti ChildFormy, aby seděla fo panelu
        */
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelObrazovka.Controls.Add(childForm);
            this.panelObrazovka.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblNadpis.Text = childForm.Text;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        // Metody tlačítek
        // Při zmáčknutí jednotlivých tlačítek v panelu "panelMenu" se otevřou v panelu panelObrazovka jednotlivé formy

        private void btnNAT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNATT(), sender);
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHolePunching(), sender);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPortMapping(), sender);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "bp_Mazur.pdf");
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při otevírání PDF souboru." + ex.Message + Path.Combine(Directory.GetCurrentDirectory(), "bp_Mazur.pdf"));
            }
        }

        private void panelObrazovka_Paint(object sender, PaintEventArgs e)
        {

        }

        //Tlačítko k uzavření otevřených forem
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                DisableButton();
                lblNadpis.Text = "Domovská obrazovka";
                btnCloseChildForm.Visible = false;
                currentButton = null;

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
