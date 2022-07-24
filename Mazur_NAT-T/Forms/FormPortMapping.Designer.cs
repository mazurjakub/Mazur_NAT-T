
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
            this.txtBoxMappingName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExtPort = new System.Windows.Forms.Label();
            this.txtBoxExternalPort = new System.Windows.Forms.TextBox();
            this.lblIntPort = new System.Windows.Forms.Label();
            this.txtBoxInternalPort = new System.Windows.Forms.TextBox();
            this.btnShowMappings = new System.Windows.Forms.Button();
            this.lblMapOutput = new System.Windows.Forms.Label();
            this.lblMappings = new System.Windows.Forms.Label();
            this.btnDeleteMapping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDeleteMappingName = new System.Windows.Forms.TextBox();
            this.lblDeleteOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMapping
            // 
            this.btnMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMapping.Location = new System.Drawing.Point(61, 382);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(140, 61);
            this.btnMapping.TabIndex = 5;
            this.btnMapping.Text = "Vytvořit mapování";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.MaximumSize = new System.Drawing.Size(770, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(765, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblCanYouSeeMe
            // 
            this.lblCanYouSeeMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCanYouSeeMe.AutoSize = true;
            this.lblCanYouSeeMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCanYouSeeMe.Location = new System.Drawing.Point(322, 63);
            this.lblCanYouSeeMe.Name = "lblCanYouSeeMe";
            this.lblCanYouSeeMe.Size = new System.Drawing.Size(212, 18);
            this.lblCanYouSeeMe.TabIndex = 7;
            this.lblCanYouSeeMe.TabStop = true;
            this.lblCanYouSeeMe.Text = "https://www.canyouseeme.org/";
            // 
            // txtBoxMappingName
            // 
            this.txtBoxMappingName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxMappingName.Location = new System.Drawing.Point(100, 269);
            this.txtBoxMappingName.Name = "txtBoxMappingName";
            this.txtBoxMappingName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMappingName.TabIndex = 8;
            this.txtBoxMappingName.Text = "Test";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 272);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Název mapování:";
            // 
            // lblExtPort
            // 
            this.lblExtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExtPort.AutoSize = true;
            this.lblExtPort.Location = new System.Drawing.Point(29, 309);
            this.lblExtPort.Name = "lblExtPort";
            this.lblExtPort.Size = new System.Drawing.Size(65, 13);
            this.lblExtPort.TabIndex = 11;
            this.lblExtPort.Text = "Externí port:";
            // 
            // txtBoxExternalPort
            // 
            this.txtBoxExternalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxExternalPort.Location = new System.Drawing.Point(100, 306);
            this.txtBoxExternalPort.Name = "txtBoxExternalPort";
            this.txtBoxExternalPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExternalPort.TabIndex = 10;
            this.txtBoxExternalPort.Text = "1702";
            // 
            // lblIntPort
            // 
            this.lblIntPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIntPort.AutoSize = true;
            this.lblIntPort.Location = new System.Drawing.Point(32, 345);
            this.lblIntPort.Name = "lblIntPort";
            this.lblIntPort.Size = new System.Drawing.Size(62, 13);
            this.lblIntPort.TabIndex = 13;
            this.lblIntPort.Text = "Interní port:";
            // 
            // txtBoxInternalPort
            // 
            this.txtBoxInternalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxInternalPort.Location = new System.Drawing.Point(100, 342);
            this.txtBoxInternalPort.Name = "txtBoxInternalPort";
            this.txtBoxInternalPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInternalPort.TabIndex = 12;
            this.txtBoxInternalPort.Text = "1602";
            // 
            // btnShowMappings
            // 
            this.btnShowMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowMappings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowMappings.Location = new System.Drawing.Point(637, 385);
            this.btnShowMappings.Name = "btnShowMappings";
            this.btnShowMappings.Size = new System.Drawing.Size(140, 61);
            this.btnShowMappings.TabIndex = 14;
            this.btnShowMappings.Text = "Zobrazit existující UPnP mapování";
            this.btnShowMappings.UseVisualStyleBackColor = true;
            this.btnShowMappings.Click += new System.EventHandler(this.btnShowMappings_Click);
            // 
            // lblMapOutput
            // 
            this.lblMapOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMapOutput.AutoSize = true;
            this.lblMapOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMapOutput.Location = new System.Drawing.Point(12, 222);
            this.lblMapOutput.Name = "lblMapOutput";
            this.lblMapOutput.Size = new System.Drawing.Size(0, 15);
            this.lblMapOutput.TabIndex = 15;
            // 
            // lblMappings
            // 
            this.lblMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMappings.AutoSize = true;
            this.lblMappings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMappings.Location = new System.Drawing.Point(502, 222);
            this.lblMappings.MaximumSize = new System.Drawing.Size(370, 150);
            this.lblMappings.MinimumSize = new System.Drawing.Size(370, 150);
            this.lblMappings.Name = "lblMappings";
            this.lblMappings.Size = new System.Drawing.Size(370, 150);
            this.lblMappings.TabIndex = 16;
            this.lblMappings.Text = "IP NAT zařízení + externí port -> Interní IP zařízení + interní port\r\n";
            this.lblMappings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDeleteMapping
            // 
            this.btnDeleteMapping.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteMapping.Location = new System.Drawing.Point(295, 385);
            this.btnDeleteMapping.Name = "btnDeleteMapping";
            this.btnDeleteMapping.Size = new System.Drawing.Size(140, 61);
            this.btnDeleteMapping.TabIndex = 17;
            this.btnDeleteMapping.Text = "Odstranit mapování";
            this.btnDeleteMapping.UseVisualStyleBackColor = true;
            this.btnDeleteMapping.Click += new System.EventHandler(this.btnDeleteMapping_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Název mapování";
            // 
            // txtBoxDeleteMappingName
            // 
            this.txtBoxDeleteMappingName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBoxDeleteMappingName.Location = new System.Drawing.Point(335, 345);
            this.txtBoxDeleteMappingName.Name = "txtBoxDeleteMappingName";
            this.txtBoxDeleteMappingName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDeleteMappingName.TabIndex = 18;
            this.txtBoxDeleteMappingName.Text = "Test";
            // 
            // lblDeleteOutput
            // 
            this.lblDeleteOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDeleteOutput.AutoSize = true;
            this.lblDeleteOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteOutput.Location = new System.Drawing.Point(263, 306);
            this.lblDeleteOutput.Name = "lblDeleteOutput";
            this.lblDeleteOutput.Size = new System.Drawing.Size(0, 15);
            this.lblDeleteOutput.TabIndex = 20;
            // 
            // FormPortMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 455);
            this.Controls.Add(this.lblDeleteOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDeleteMappingName);
            this.Controls.Add(this.btnDeleteMapping);
            this.Controls.Add(this.lblMappings);
            this.Controls.Add(this.lblMapOutput);
            this.Controls.Add(this.btnShowMappings);
            this.Controls.Add(this.lblIntPort);
            this.Controls.Add(this.txtBoxInternalPort);
            this.Controls.Add(this.lblExtPort);
            this.Controls.Add(this.txtBoxExternalPort);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxMappingName);
            this.Controls.Add(this.lblCanYouSeeMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMapping);
            this.MinimumSize = new System.Drawing.Size(800, 39);
            this.Name = "FormPortMapping";
            this.Text = "Port Mapping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblCanYouSeeMe;
        private System.Windows.Forms.TextBox txtBoxMappingName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExtPort;
        private System.Windows.Forms.TextBox txtBoxExternalPort;
        private System.Windows.Forms.Label lblIntPort;
        private System.Windows.Forms.TextBox txtBoxInternalPort;
        private System.Windows.Forms.Button btnShowMappings;
        private System.Windows.Forms.Label lblMapOutput;
        private System.Windows.Forms.Label lblMappings;
        private System.Windows.Forms.Button btnDeleteMapping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDeleteMappingName;
        private System.Windows.Forms.Label lblDeleteOutput;
    }
}