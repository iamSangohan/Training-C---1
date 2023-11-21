using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravauxPratiques2
{
    public partial class Factoriel : Form
    {
        public Factoriel()
        {
            InitializeComponent();
        }

        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            // Verifier si le nombre est un entier
            int nombre;
            if (!int.TryParse(TbNombre.Text, out nombre))
            {
                MessageBox.Show("Le nombre doit être un entier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Calculer la factoriel du nombre
            int factoriel = 1;
            for (int i = 1; i <= nombre; i++)
            {
                factoriel *= i;
            }
            LbResultat.Text = factoriel.ToString();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
    }
}
