namespace TravauxPratiques2
{
    partial class Factoriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factoriel));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCalculer = new System.Windows.Forms.Button();
            this.LbResultat = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factoriel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCalculer);
            this.panel1.Controls.Add(this.LbResultat);
            this.panel1.Controls.Add(this.TbNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(95, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 198);
            this.panel1.TabIndex = 1;
            // 
            // BtnCalculer
            // 
            this.BtnCalculer.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalculer.Image")));
            this.BtnCalculer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalculer.Location = new System.Drawing.Point(394, 53);
            this.BtnCalculer.Name = "BtnCalculer";
            this.BtnCalculer.Size = new System.Drawing.Size(175, 53);
            this.BtnCalculer.TabIndex = 2;
            this.BtnCalculer.Text = "Calculer";
            this.BtnCalculer.UseVisualStyleBackColor = true;
            this.BtnCalculer.Click += new System.EventHandler(this.BtnCalculer_Click);
            // 
            // LbResultat
            // 
            this.LbResultat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResultat.Location = new System.Drawing.Point(182, 134);
            this.LbResultat.Name = "LbResultat";
            this.LbResultat.Size = new System.Drawing.Size(236, 37);
            this.LbResultat.TabIndex = 2;
            this.LbResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(57, 68);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(151, 22);
            this.TbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Donnez un entier positif :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnQuitter);
            this.panel2.Controls.Add(this.BtnRetour);
            this.panel2.Location = new System.Drawing.Point(100, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 79);
            this.panel2.TabIndex = 2;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuitter.Location = new System.Drawing.Point(366, 9);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(175, 53);
            this.BtnQuitter.TabIndex = 1;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnRetour
            // 
            this.BtnRetour.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetour.Image")));
            this.BtnRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRetour.Location = new System.Drawing.Point(52, 9);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(175, 53);
            this.BtnRetour.TabIndex = 0;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // Factoriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Factoriel";
            this.Text = "Factoriel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCalculer;
        private System.Windows.Forms.Label LbResultat;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnRetour;
    }
}