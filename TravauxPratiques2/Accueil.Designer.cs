namespace TravauxPratiques2
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.BtnTableau = new System.Windows.Forms.Button();
            this.BtnFactoriel = new System.Windows.Forms.Button();
            this.BtnJouer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTableau
            // 
            this.BtnTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTableau.Image = ((System.Drawing.Image)(resources.GetObject("BtnTableau.Image")));
            this.BtnTableau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTableau.Location = new System.Drawing.Point(291, 45);
            this.BtnTableau.Name = "BtnTableau";
            this.BtnTableau.Size = new System.Drawing.Size(208, 64);
            this.BtnTableau.TabIndex = 0;
            this.BtnTableau.Text = "Tableau";
            this.BtnTableau.UseVisualStyleBackColor = true;
            this.BtnTableau.Click += new System.EventHandler(this.BtnTableau_Click);
            // 
            // BtnFactoriel
            // 
            this.BtnFactoriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactoriel.Image = ((System.Drawing.Image)(resources.GetObject("BtnFactoriel.Image")));
            this.BtnFactoriel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactoriel.Location = new System.Drawing.Point(291, 139);
            this.BtnFactoriel.Name = "BtnFactoriel";
            this.BtnFactoriel.Size = new System.Drawing.Size(208, 64);
            this.BtnFactoriel.TabIndex = 1;
            this.BtnFactoriel.Text = "Factoriel";
            this.BtnFactoriel.UseVisualStyleBackColor = true;
            this.BtnFactoriel.Click += new System.EventHandler(this.BtnFactoriel_Click);
            // 
            // BtnJouer
            // 
            this.BtnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJouer.Image = ((System.Drawing.Image)(resources.GetObject("BtnJouer.Image")));
            this.BtnJouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJouer.Location = new System.Drawing.Point(291, 235);
            this.BtnJouer.Name = "BtnJouer";
            this.BtnJouer.Size = new System.Drawing.Size(208, 64);
            this.BtnJouer.TabIndex = 2;
            this.BtnJouer.Text = "Jouer";
            this.BtnJouer.UseVisualStyleBackColor = true;
            this.BtnJouer.Click += new System.EventHandler(this.BtnJouer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuitter.Location = new System.Drawing.Point(291, 330);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(208, 64);
            this.BtnQuitter.TabIndex = 3;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "</> with ❤ by Sangohan";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnJouer);
            this.Controls.Add(this.BtnFactoriel);
            this.Controls.Add(this.BtnTableau);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTableau;
        private System.Windows.Forms.Button BtnFactoriel;
        private System.Windows.Forms.Button BtnJouer;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label label1;
    }
}

