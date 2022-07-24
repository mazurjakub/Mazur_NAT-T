
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHP
            // 
            this.panelHP.Controls.Add(this.label1);
            this.panelHP.Controls.Add(this.txtBoxKey);
            this.panelHP.Controls.Add(this.lblOutput);
            this.panelHP.Controls.Add(this.label2);
            this.panelHP.Controls.Add(this.btnConnect);
            this.panelHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHP.Location = new System.Drawing.Point(0, 0);
            this.panelHP.Name = "panelHP";
            this.panelHP.Size = new System.Drawing.Size(888, 504);
            this.panelHP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tato demonstrace umožňuje navázat spojení mezi dvěma klienty pomocí metody Hole P" +
    "unching.\r\nZadejte u obou klientů stejný klíč, aby mohlo vzniknou peer-to-peer sp" +
    "ojení.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(669, 431);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(140, 61);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Odeslat zprávu serveru";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(56, 116);
            this.lblOutput.MaximumSize = new System.Drawing.Size(450, 300);
            this.lblOutput.MinimumSize = new System.Drawing.Size(450, 300);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(450, 300);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Okno pro komunikaci se serverem a klientem";
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Location = new System.Drawing.Point(701, 385);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Klíč:";
            // 
            // FormHolePunching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 504);
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
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxKey;
    }
}