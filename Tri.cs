using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace background_worker
{
    class Tri
    {
        public static void TriSelectionPermutation(double[] tableau)
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
            }
        }
    }
}
