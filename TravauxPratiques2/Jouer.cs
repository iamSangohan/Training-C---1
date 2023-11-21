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
    public partial class Jouer : Form
    {
        List<Label> LTxtC = new List<Label>();
        List<TextBox> LTxtP = new List<TextBox>();
        int nbJeux = 0; 
        bool animation = false;

        public Jouer()
        {
            InitializeComponent();

            int n1, n2, n3, n4;
            Random random = new Random();
            n1 = random.Next(0, 10);
            Lb1.Text = n1.ToString();

            do
                n2 = random.Next(0, 10);
            while (n2 == n1);
            Lb2.Text = n2.ToString();

            do
                n3 = random.Next(0, 10);
            while (n3 == n2 || n3 == n1);
            Lb3.Text = n3.ToString();

            do
                n4 = random.Next(0, 10);
            while (n4 == n3 || n4 == n2 || n4 == n1);
            Lb4.Text = n4.ToString();

            LTxtC.Add(Lb1);
            LTxtC.Add(Lb2);
            LTxtC.Add(Lb3);
            LTxtC.Add(Lb4);  

            LTxtP.Add(Tb1);
            LTxtP.Add(Tb2);
            LTxtP.Add(Tb3);
            LTxtP.Add(Tb4);

            // Cacher les labels
            for (int i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.White;
        }

        private void BtnCacher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.White;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Jouer jouer = new Jouer();
            jouer.Show();
            this.Close();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.Black;
        }

        private void BtnRejouer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White;
                LTxtP[i].Text = "";
            }
            LTxtP[0].Focus();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void BtnQuitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVerifier_Click(object sender, EventArgs e)
        {
            int i, j, correct = 0;
            for (i = 0; i < 4; i++)
            {
                if (LTxtP[i].Text == LTxtC[i].Text)
                {
                    LTxtP[i].BackColor = Color.Lime;
                    correct++;
                }
                else
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (LTxtP[i].Text == LTxtC[j].Text)
                        {
                            LTxtP[i].BackColor = Color.Yellow;
                            break;
                        }
                        else
                        {
                            LTxtP[i].BackColor = Color.Red;
                        }
                    }
                }
            }

            if (correct == 4)
            {
                for (i = 0; i < 4; i++)
                    LTxtC[i].ForeColor = Color.Black;

                MessageBox.Show("Vous avez gagné", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nbJeux++;
                LbEssai.Text = (nbJeux + 1).ToString();
                if (nbJeux == 3)
                {
                    GrB1.Enabled = false;
                    for (i = 0; i < 4; i++)
                        LTxtC[i].ForeColor = Color.Black;
                    MessageBox.Show("Vous avez perdu", "Game Over",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
