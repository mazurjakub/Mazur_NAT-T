
namespace Mazur_NAT_T.Forms
{
    partial class FormPortMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortMapping));
            this.btnMapping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCanYouSeeMe = new System.Windows.Forms.LinkLabel();
            this.txtBoxPortName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExtPort = new System.Windows.Forms.Label();
            this.txtBoxExternalPort = new System.Windows.Forms.TextBox();
            this.lblIntPort = new System.Windows.Forms.Label();
            this.txtBoxInternalPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMapping
            // 
            this.btnMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMapping.Location = new System.Drawing.Point(36, 361);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(140, 61);
            this.btnMapping.TabIndex = 5;
            this.btnMapping.Text = "Namapovat port";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.MaximumSize = new System.Drawing.Size(770, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblCanYouSeeMe
            // 
            this.lblCanYouSeeMe.AutoSize = true;
            this.lblCanYouSeeMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCanYouSeeMe.Location = new System.Drawing.Point(276, 88);
            this.lblCanYouSeeMe.Name = "lblCanYouSeeMe";
            this.lblCanYouSeeMe.Size = new System.Drawing.Size(212, 18);
            this.lblCanYouSeeMe.TabIndex = 7;
            this.lblCanYouSeeMe.TabStop = true;
            this.lblCanYouSeeMe.Text = "https://www.canyouseeme.org/";
            // 
            // txtBoxPortName
            // 
            this.txtBoxPortName.Location = new System.Drawing.Point(119, 189);
            this.txtBoxPortName.Name = "txtBoxPortName";
            this.txtBoxPortName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPortName.TabIndex = 8;
            this.txtBoxPortName.Text = "Test";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Název mapování:";
            // 
            // lblExtPort
            // 
            this.lblExtPort.AutoSize = true;
            this.lblExtPort.Location = new System.Drawing.Point(48, 229);
            this.lblExtPort.Name = "lblExtPort";
            this.lblExtPort.Size = new System.Drawing.Size(65, 13);
            this.lblExtPort.TabIndex = 11;
            this.lblExtPort.Text = "Externí port:";
            // 
            // txtBoxExternalPort
            // 
            this.txtBoxExternalPort.Location = new System.Drawing.Point(119, 226);
            this.txtBoxExternalPort.Name = "txtBoxExternalPort";
            this.txtBoxExternalPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExternalPort.TabIndex = 10;
            this.txtBoxExternalPort.Text = "1702";
            // 
            // lblIntPort
            // 
            this.lblIntPort.AutoSize = true;
            this.lblIntPort.Location = new System.Drawing.Point(51, 265);
            this.lblIntPort.Name = "lblIntPort";
            this.lblIntPort.Size = new System.Drawing.Size(62, 13);
            this.lblIntPort.TabIndex = 13;
            this.lblIntPort.Text = "Interní port:";
            // 
            // txtBoxInternalPort
            // 
            this.txtBoxInternalPort.Location = new System.Drawing.Point(119, 262);
            this.txtBoxInternalPort.Name = "txtBoxInternalPort";
            this.txtBoxInternalPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInternalPort.TabIndex = 12;
            this.txtBoxInternalPort.Text = "1602";
            // 
            // FormPortMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntPort);
            this.Controls.Add(this.txtBoxInternalPort);
            this.Controls.Add(this.lblExtPort);
            this.Controls.Add(this.txtBoxExternalPort);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxPortName);
            this.Controls.Add(this.lblCanYouSeeMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMapping);
            this.Name = "FormPortMapping";
            this.Text = "Port Mapping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblCanYouSeeMe;
        private System.Windows.Forms.TextBox txtBoxPortName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExtPort;
        private System.Windows.Forms.TextBox txtBoxExternalPort;
        private System.Windows.Forms.Label lblIntPort;
        private System.Windows.Forms.TextBox txtBoxInternalPort;
    }
}