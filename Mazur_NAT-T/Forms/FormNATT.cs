using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mazur_NAT_T.Forms
{
    public partial class FormNATT : Form
    {
        public FormNATT()
        {
            InitializeComponent();
        }
/*
        public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return font.Size * ratio;
        }*/




        private void FormNATT_Load(object sender, EventArgs e)
        {
            
        }

        private void lblNadpisNAT_Click(object sender, EventArgs e)
        {

        }

        private void lblTextNAT_Paint(object sender, PaintEventArgs e)
        {
          /*  float fontSize = NewFontSize(e.Graphics, panelNATT.Bounds.Size, lblTextNAT.Font, lblTextNAT.Text);
            Font f = new Font("Microsoft Sans Serif", fontSize, FontStyle.Bold);
            lblTextNAT.Font = f;*/
        }
    }
}
