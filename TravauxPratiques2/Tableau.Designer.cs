namespace TravauxPratiques2
{
    partial class Tableau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tableau));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TbNote = new System.Windows.Forms.TextBox();
            this.LbTableau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnCalculer = new System.Windows.Forms.Button();
            this.LbSup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LbInf = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbEcart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbMoyenne = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRegister);
            this.groupBox1.Controls.Add(this.TbNote);
            this.groupBox1.Controls.Add(this.LbTableau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegister.Image")));
            this.BtnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegister.Location = new System.Drawing.Point(408, 20);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(180, 51);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Enregistrer";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TbNote
            // 
            this.TbNote.Location = new System.Drawing.Point(200, 35);
            this.TbNote.Name = "TbNote";
            this.TbNote.Size = new System.Drawing.Size(53, 22);
            this.TbNote.TabIndex = 2;
            // 
            // LbTableau
            // 
            this.LbTableau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTableau.Location = new System.Drawing.Point(124, 88);
            this.LbTableau.Name = "LbTableau";
            this.LbTableau.Size = new System.Drawing.Size(385, 27);
            this.LbTableau.TabIndex = 1;
            this.LbTableau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez la note de l\'eleve n1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnQuitter);
            this.panel1.Controls.Add(this.BtnRetour);
            this.panel1.Controls.Add(this.BtnCalculer);
            this.panel1.Controls.Add(this.LbSup);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LbInf);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LbEcart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LbMoyenne);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(89, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 235);
            this.panel1.TabIndex = 1;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuitter.Location = new System.Drawing.Point(401, 150);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(180, 51);
            this.BtnQuitter.TabIndex = 14;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnRetour
            // 
            this.BtnRetour.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetour.Image")));
            this.BtnRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetour.Location = new System.Drawing.Point(401, 88);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(180, 51);
            this.BtnRetour.TabIndex = 13;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // BtnCalculer
            // 
            this.BtnCalculer.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalculer.Image")));
            this.BtnCalculer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalculer.Location = new System.Drawing.Point(401, 26);
            this.BtnCalculer.Name = "BtnCalculer";
            this.BtnCalculer.Size = new System.Drawing.Size(180, 51);
            this.BtnCalculer.TabIndex = 12;
            this.BtnCalculer.Text = "Calculer";
            this.BtnCalculer.UseVisualStyleBackColor = true;
            this.BtnCalculer.Click += new System.EventHandler(this.BtnCalculer_Click);
            // 
            // LbSup
            // 
            this.LbSup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbSup.Location = new System.Drawing.Point(199, 178);
            this.LbSup.Name = "LbSup";
            this.LbSup.Size = new System.Drawing.Size(74, 30);
            this.LbSup.TabIndex = 11;
            this.LbSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nombres de notes 10> :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbInf
            // 
            this.LbInf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbInf.Location = new System.Drawing.Point(199, 125);
            this.LbInf.Name = "LbInf";
            this.LbInf.Size = new System.Drawing.Size(74, 30);
            this.LbInf.TabIndex = 9;
            this.LbInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombres de notes 10< :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbEcart
            // 
            this.LbEcart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbEcart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbEcart.Location = new System.Drawing.Point(199, 75);
            this.LbEcart.Name = "LbEcart";
            this.LbEcart.Size = new System.Drawing.Size(74, 30);
            this.LbEcart.TabIndex = 7;
            this.LbEcart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ecart-type :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbMoyenne
            // 
            this.LbMoyenne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbMoyenne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbMoyenne.Location = new System.Drawing.Point(199, 26);
            this.LbMoyenne.Name = "LbMoyenne";
            this.LbMoyenne.Size = new System.Drawing.Size(74, 30);
            this.LbMoyenne.TabIndex = 5;
            this.LbMoyenne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "La moyenne de la classe : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tableau";
            this.Text = "Tableau";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TbNote;
        private System.Windows.Forms.Label LbTableau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbMoyenne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button BtnCalculer;
        private System.Windows.Forms.Label LbSup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LbInf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbEcart;
        private System.Windows.Forms.Label label6;
    }
}