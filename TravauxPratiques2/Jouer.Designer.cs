namespace TravauxPratiques2
{
    partial class Jouer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jouer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrB1 = new System.Windows.Forms.GroupBox();
            this.Lb4 = new System.Windows.Forms.Label();
            this.Lb3 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.BtnCacher = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Tb3 = new System.Windows.Forms.TextBox();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.Tb4 = new System.Windows.Forms.TextBox();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.BtnVerifier = new System.Windows.Forms.Button();
            this.BtnRejouer = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnQuitt = new System.Windows.Forms.Button();
            this.LbEssai = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.GrB1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LbEssai);
            this.panel2.Controls.Add(this.GrB1);
            this.panel2.Controls.Add(this.BtnCacher);
            this.panel2.Controls.Add(this.BtnShow);
            this.panel2.Controls.Add(this.BtnNew);
            this.panel2.Location = new System.Drawing.Point(38, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 144);
            this.panel2.TabIndex = 0;
            // 
            // GrB1
            // 
            this.GrB1.Controls.Add(this.Lb4);
            this.GrB1.Controls.Add(this.Lb3);
            this.GrB1.Controls.Add(this.Lb2);
            this.GrB1.Controls.Add(this.Lb1);
            this.GrB1.Location = new System.Drawing.Point(169, 12);
            this.GrB1.Name = "GrB1";
            this.GrB1.Size = new System.Drawing.Size(368, 90);
            this.GrB1.TabIndex = 3;
            this.GrB1.TabStop = false;
            this.GrB1.Text = "Nombres a deviner";
            // 
            // Lb4
            // 
            this.Lb4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb4.Location = new System.Drawing.Point(283, 31);
            this.Lb4.Name = "Lb4";
            this.Lb4.Size = new System.Drawing.Size(60, 36);
            this.Lb4.TabIndex = 3;
            this.Lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb3
            // 
            this.Lb3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb3.Location = new System.Drawing.Point(194, 31);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(60, 36);
            this.Lb3.TabIndex = 2;
            this.Lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb2
            // 
            this.Lb2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb2.Location = new System.Drawing.Point(102, 31);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(60, 36);
            this.Lb2.TabIndex = 1;
            this.Lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb1
            // 
            this.Lb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb1.Location = new System.Drawing.Point(15, 31);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(60, 36);
            this.Lb1.TabIndex = 0;
            this.Lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCacher
            // 
            this.BtnCacher.Image = ((System.Drawing.Image)(resources.GetObject("BtnCacher.Image")));
            this.BtnCacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCacher.Location = new System.Drawing.Point(556, 78);
            this.BtnCacher.Name = "BtnCacher";
            this.BtnCacher.Size = new System.Drawing.Size(149, 53);
            this.BtnCacher.TabIndex = 2;
            this.BtnCacher.Text = "Cacher";
            this.BtnCacher.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Image = ((System.Drawing.Image)(resources.GetObject("BtnShow.Image")));
            this.BtnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShow.Location = new System.Drawing.Point(556, 9);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(149, 53);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Afficher";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.Location = new System.Drawing.Point(14, 44);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(149, 53);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New Partie";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Tb3);
            this.groupBox4.Controls.Add(this.Tb2);
            this.groupBox4.Controls.Add(this.Tb4);
            this.groupBox4.Controls.Add(this.Tb1);
            this.groupBox4.Controls.Add(this.BtnVerifier);
            this.groupBox4.Location = new System.Drawing.Point(223, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 137);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Tb3
            // 
            this.Tb3.Location = new System.Drawing.Point(179, 61);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(62, 22);
            this.Tb3.TabIndex = 5;
            // 
            // Tb2
            // 
            this.Tb2.Location = new System.Drawing.Point(92, 61);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(62, 22);
            this.Tb2.TabIndex = 4;
            // 
            // Tb4
            // 
            this.Tb4.Location = new System.Drawing.Point(266, 61);
            this.Tb4.Name = "Tb4";
            this.Tb4.Size = new System.Drawing.Size(62, 22);
            this.Tb4.TabIndex = 3;
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(6, 61);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(62, 22);
            this.Tb1.TabIndex = 2;
            // 
            // BtnVerifier
            // 
            this.BtnVerifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerifier.Image")));
            this.BtnVerifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerifier.Location = new System.Drawing.Point(372, 43);
            this.BtnVerifier.Name = "BtnVerifier";
            this.BtnVerifier.Size = new System.Drawing.Size(149, 53);
            this.BtnVerifier.TabIndex = 1;
            this.BtnVerifier.Text = "Verifier";
            this.BtnVerifier.UseVisualStyleBackColor = true;
            this.BtnVerifier.Click += new System.EventHandler(this.BtnVerifier_Click);
            // 
            // BtnRejouer
            // 
            this.BtnRejouer.Image = ((System.Drawing.Image)(resources.GetObject("BtnRejouer.Image")));
            this.BtnRejouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRejouer.Location = new System.Drawing.Point(53, 249);
            this.BtnRejouer.Name = "BtnRejouer";
            this.BtnRejouer.Size = new System.Drawing.Size(149, 53);
            this.BtnRejouer.TabIndex = 2;
            this.BtnRejouer.Text = "Rejouer";
            this.BtnRejouer.UseVisualStyleBackColor = true;
            this.BtnRejouer.Click += new System.EventHandler(this.BtnRejouer_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(215, 375);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(149, 53);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnQuitt
            // 
            this.BtnQuitt.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitt.Image")));
            this.BtnQuitt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuitt.Location = new System.Drawing.Point(433, 375);
            this.BtnQuitt.Name = "BtnQuitt";
            this.BtnQuitt.Size = new System.Drawing.Size(149, 53);
            this.BtnQuitt.TabIndex = 7;
            this.BtnQuitt.Text = "Quitter";
            this.BtnQuitt.UseVisualStyleBackColor = true;
            this.BtnQuitt.Click += new System.EventHandler(this.BtnQuitt_Click);
            // 
            // LbEssai
            // 
            this.LbEssai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbEssai.Location = new System.Drawing.Point(311, 111);
            this.LbEssai.Name = "LbEssai";
            this.LbEssai.Size = new System.Drawing.Size(100, 23);
            this.LbEssai.TabIndex = 4;
            this.LbEssai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jouer
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuitt);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRejouer);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Name = "Jouer";
            this.panel2.ResumeLayout(false);
            this.GrB1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox GrB1;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button BtnCacher;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Label Lb4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Tb3;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.TextBox Tb4;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.Button BtnVerifier;
        private System.Windows.Forms.Button BtnRejouer;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnQuitt;
        private System.Windows.Forms.Label LbEssai;
    }
}