using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace background_worker
{
    public partial class Form1 : Form
    {
        private double[] tableau;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitBtn_Click(object sender, EventArgs e)
        {
            int taille;
            if(int.TryParse(txtTaille.Text, out taille))
            {
                tableau = new double[taille];
                Initialiser(tableau);
                Afficher(tableau,listValeursNonTriees);
            }
            else
            {
                MessageBox.Show("Taille incorrecte!");
            }
        }
        private void Initialiser(double[] tableau)
        {
            Random r = new Random();
            for(int i=0;i<tableau.Length;i++)
            {
                tableau[i] = r.NextDouble() * tableau.Length;
            }
        }
        private void Afficher(double[] talbeau,ListBox liste)
        {
            liste.Items.Clear();
            foreach(var e in tableau)
            {
                liste.Items.Add(e);
            }
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            formTri f = new formTri(tableau);
            f.ShowDialog();
            Afficher(f.tableau,listValeursTriees);
            
        }
    }
   
}
