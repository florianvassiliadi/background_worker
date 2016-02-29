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
            Tri(tableau);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Tri(tableau);
        }

        private void Tri(double[] tableau)
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

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
