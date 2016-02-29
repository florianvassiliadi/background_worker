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
            Tri.TriSelectionPermutation(tableau);
        }
    }
}
