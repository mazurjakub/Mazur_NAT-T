﻿
namespace Mazur_NAT_T
{
    partial class FormHlaniMenu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHlaniMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnNAT = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelNazevApp = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblNadpis = new System.Windows.Forms.Label();
            this.panelObrazovka = new System.Windows.Forms.Panel();
            this.lblTextUvod = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelObrazovka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panelMenu.Controls.Add(this.btnEnd);
            this.panelMenu.Controls.Add(this.btnText);
            this.panelMenu.Controls.Add(this.btnPM);
            this.panelMenu.Controls.Add(this.btnHP);
            this.panelMenu.Controls.Add(this.btnNAT);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnEnd
            // 
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEnd, "btnEnd");
            this.btnEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnText
            // 
            this.btnText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnText, "btnText");
            this.btnText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnText.Name = "btnText";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPM
            // 
            this.btnPM.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPM, "btnPM");
            this.btnPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPM.Name = "btnPM";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnHP
            // 
            this.btnHP.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHP, "btnHP");
            this.btnHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHP.Name = "btnHP";
            this.btnHP.UseVisualStyleBackColor = true;
            this.btnHP.Click += new System.EventHandler(this.btnHP_Click);
            // 
            // btnNAT
            // 
            this.btnNAT.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNAT, "btnNAT");
            this.btnNAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNAT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNAT.Name = "btnNAT";
            this.btnNAT.UseVisualStyleBackColor = true;
            this.btnNAT.Click += new System.EventHandler(this.btnNAT_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.labelNazevApp);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // labelNazevApp
            // 
            resources.ApplyResources(this.labelNazevApp, "labelNazevApp");
            this.labelNazevApp.Name = "labelNazevApp";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblNadpis);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // btnCloseChildForm
            // 
            resources.ApplyResources(this.btnCloseChildForm, "btnCloseChildForm");
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.Image = global::Mazur_NAT_T.Properties.Resources.cross11;
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblNadpis
            // 
            resources.ApplyResources(this.lblNadpis, "lblNadpis");
            this.lblNadpis.Name = "lblNadpis";
            // 
            // panelObrazovka
            // 
            this.panelObrazovka.Controls.Add(this.lblTextUvod);
            this.panelObrazovka.Controls.Add(this.lblAutor);
            this.panelObrazovka.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelObrazovka, "panelObrazovka");
            this.panelObrazovka.Name = "panelObrazovka";
            this.panelObrazovka.Paint += new System.Windows.Forms.PaintEventHandler(this.panelObrazovka_Paint);
            // 
            // lblTextUvod
            // 
            resources.ApplyResources(this.lblTextUvod, "lblTextUvod");
            this.lblTextUvod.Name = "lblTextUvod";
            // 
            // lblAutor
            // 
            resources.ApplyResources(this.lblAutor, "lblAutor");
            this.lblAutor.Name = "lblAutor";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Mazur_NAT_T.Properties.Resources.UpolLOgo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormHlaniMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelObrazovka);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormHlaniMenu";
            this.ShowIcon = false;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelObrazovka.ResumeLayout(false);
            this.panelObrazovka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnNAT;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblNadpis;
        private System.Windows.Forms.Label labelNazevApp;
        private System.Windows.Forms.Panel panelObrazovka;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTextUvod;
    }
}

