
namespace Mazur_NAT_T.Forms
{
    partial class FormNATT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNATT));
            this.panelNATT = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNadpisNATT = new System.Windows.Forms.Label();
            this.lblNadpisNAT = new System.Windows.Forms.Label();
            this.lblTextNAT = new System.Windows.Forms.Label();
            this.panelNATT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNATT
            // 
            this.panelNATT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNATT.Controls.Add(this.label1);
            this.panelNATT.Controls.Add(this.lblNadpisNATT);
            this.panelNATT.Controls.Add(this.lblNadpisNAT);
            this.panelNATT.Controls.Add(this.lblTextNAT);
            this.panelNATT.Location = new System.Drawing.Point(0, 1);
            this.panelNATT.Name = "panelNATT";
            this.panelNATT.Size = new System.Drawing.Size(889, 504);
            this.panelNATT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(114, 243);
            this.label1.MaximumSize = new System.Drawing.Size(650, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 144);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblNadpisNATT
            // 
            this.lblNadpisNATT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNadpisNATT.AutoSize = true;
            this.lblNadpisNATT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNadpisNATT.Location = new System.Drawing.Point(402, 168);
            this.lblNadpisNATT.Name = "lblNadpisNATT";
            this.lblNadpisNATT.Size = new System.Drawing.Size(91, 29);
            this.lblNadpisNATT.TabIndex = 4;
            this.lblNadpisNATT.Text = "NAT-T";
            // 
            // lblNadpisNAT
            // 
            this.lblNadpisNAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNadpisNAT.AutoSize = true;
            this.lblNadpisNAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNadpisNAT.Location = new System.Drawing.Point(417, 19);
            this.lblNadpisNAT.Name = "lblNadpisNAT";
            this.lblNadpisNAT.Size = new System.Drawing.Size(65, 29);
            this.lblNadpisNAT.TabIndex = 3;
            this.lblNadpisNAT.Text = "NAT";
            this.lblNadpisNAT.Click += new System.EventHandler(this.lblNadpisNAT_Click);
            // 
            // lblTextNAT
            // 
            this.lblTextNAT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextNAT.AutoSize = true;
            this.lblTextNAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTextNAT.Location = new System.Drawing.Point(114, 85);
            this.lblTextNAT.MaximumSize = new System.Drawing.Size(650, 0);
            this.lblTextNAT.Name = "lblTextNAT";
            this.lblTextNAT.Size = new System.Drawing.Size(649, 54);
            this.lblTextNAT.TabIndex = 2;
            this.lblTextNAT.Text = "Network Address Translation je v počítačových sítích způsob úpravy síťového provo" +
    "zu procházejícího přes router přepisem zdrojové nebo cílové IP adresy, případně " +
    "i hlaviček protokolů vyšší vrstvy.";
            this.lblTextNAT.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTextNAT_Paint);
            // 
            // FormNATT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 504);
            this.Controls.Add(this.panelNATT);
            this.Name = "FormNATT";
            this.Text = "NAT, NAT-T";
            this.Load += new System.EventHandler(this.FormNATT_Load);
            this.panelNATT.ResumeLayout(false);
            this.panelNATT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNATT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNadpisNATT;
        private System.Windows.Forms.Label lblNadpisNAT;
        private System.Windows.Forms.Label lblTextNAT;
    }
}