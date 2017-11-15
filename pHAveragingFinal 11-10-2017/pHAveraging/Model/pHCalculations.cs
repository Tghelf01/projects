using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pHAveraging.Model
{
    public class pHCalculations
    {
        public static double CalcAverage(List<double> pHList)
        {
            double total = pHList.Sum();
            return total / pHList.Count;
        }
    }
}
