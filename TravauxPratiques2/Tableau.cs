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
    public partial class Tableau : Form
    {
        // Initialisation d'une liste de nombres
        List<int> nombres = new List<int>();

        public Tableau()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Verifier que la valeur saisie est un nombre sinon afficher un message d'erreur
            if (!int.TryParse(TbNote.Text, out int nombre))
            {
                MessageBox.Show("Veuillez saisir un nombre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recuperer la valeur saisie et la mettre dans la liste
            nombres.Add(nombre);

            // Afficher la valeur saisie dans la liste
            LbTableau.Text = "";
            LbTableau.Text = "|";
            for (int i = 0; i < nombres.Count; i++)
            {
                LbTableau.Text += nombres[i] + " | ";
            }
            label1.Text = "Entrez la note de l'eleve n" + (nombres.Count+1);
        }

        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            // Calculer la moyenne des nombres dans la liste
            double somme = 0;
            for (int i = 0; i < nombres.Count; i++)
            {
                somme += nombres[i];
            }
            double moyenne = somme / nombres.Count;
            LbMoyenne.Text = moyenne.ToString();

            // Calculer l'ecart type des nombres dans la liste
            double sommeEcart = 0;
            for (int i = 0; i < nombres.Count; i++)
            {
                sommeEcart += Math.Pow(nombres[i] - moyenne, 2);
            }
            double ecartType = Math.Sqrt(sommeEcart / nombres.Count);
            LbEcart.Text = ecartType.ToString();

            // Calculer le nombre de notes superieures a 10
            int nombreSup = 0;
            for (int i = 0; i < nombres.Count; i++)
            {
                if (nombres[i] > 10)
                {
                    nombreSup++;
                }
            }
            LbSup.Text = nombreSup.ToString();

            // Calculer le nombre de notes inferieures a 10
            int nombreInf = 0;
            for (int i = 0; i < nombres.Count; i++)
            {
                if (nombres[i] < 10)
                {
                    nombreInf++;
                }
            }
            LbInf.Text = nombreInf.ToString();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
