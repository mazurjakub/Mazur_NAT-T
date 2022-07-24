
namespace Mazur_NAT_T.Forms
{
    partial class FormHolePunching
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
            this.panelHP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnKlient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHP
            // 
            this.panelHP.Controls.Add(this.label2);
            this.panelHP.Controls.Add(this.label1);
            this.panelHP.Controls.Add(this.btnServer);
            this.panelHP.Controls.Add(this.btnKlient);
            this.panelHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHP.Location = new System.Drawing.Point(0, 0);
            this.panelHP.Name = "panelHP";
            this.panelHP.Size = new System.Drawing.Size(800, 450);
            this.panelHP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hole punching je metoda.....";
            // 
            // btnServer
            // 
            this.btnServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnServer.Location = new System.Drawing.Point(616, 343);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(140, 61);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Vytvořit server";
            this.btnServer.UseVisualStyleBackColor = true;
            // 
            // btnKlient
            // 
            this.btnKlient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlient.Location = new System.Drawing.Point(66, 343);
            this.btnKlient.Name = "btnKlient";
            this.btnKlient.Size = new System.Drawing.Size(140, 61);
            this.btnKlient.TabIndex = 1;
            this.btnKlient.Text = "Vytvořit klienta";
            this.btnKlient.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 216);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "V této demonstraci si vytvořte server a 2 klienty. \r\nZadejte do obou klientů stej" +
    "ný unikátní klíč a server mezi nimy vytvoří peer-to-peer připojení.";
            // 
            // FormHolePunching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHP);
            this.Name = "FormHolePunching";
            this.Text = "Hole Punching";
            this.Load += new System.EventHandler(this.FormHolePunching_Load);
            this.panelHP.ResumeLayout(false);
            this.panelHP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnKlient;
        private System.Windows.Forms.Label label2;
    }
}