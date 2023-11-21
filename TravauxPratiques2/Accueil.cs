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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnJouer_Click(object sender, EventArgs e)
        {
            Jouer jouer = new Jouer();
            jouer.Show();
            this.Hide();
        }

        private void BtnFactoriel_Click(object sender, EventArgs e)
        {
            Factoriel factoriel = new Factoriel();
            factoriel.Show();
            this.Hide();
        }

        private void BtnTableau_Click(object sender, EventArgs e)
        {
            Tableau tableau = new Tableau();
            tableau.Show();
            this.Hide();
        }
    }
}
