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
    public partial class formTri : Form
    {
        public double[] tableau { get; private set; }
        public formTri(double[] tableau)
        {
            InitializeComponent();
            this.tableau = tableau;
        }

        private void formTri_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Tri(tableau, e);
        }

        private void Tri(double[] tableau,DoWorkEventArgs e)
        {
            int i, iRech, iMin;
            double tmp;
            for (i = 0; i < tableau.Length; i++)
            {
                for (iRech = iMin = i; iRech < tableau.Length; iRech++)
                {
                    if (tableau[iRech] < tableau[iMin])
                    {
                        iMin = iRech;
                    }
                }
                if (iMin != i)
                {
                    tmp = tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }
                backgroundWorker1.ReportProgress((i * 100) / (tableau.Length - 1));
                //Annulation demandé?
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show("Tri annulé!");
            }
            else
            {
                MessageBox.Show("Tri terminé!");
                btnOk.Enabled = true;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
