using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChurinDV.Sprint2.Task4.V22.Lib
{
    public class DataService : ISprint2Task4V22
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(x - 3 > y * 2 - 21 ? Math.Pow(x, 2) + 12 * y - (2 / x) : ((x * x + Math.Cos(y * y) + 17) / (y * y - Math.Sin(y * y) + 3)), 3);
            return res;
        }
    }
}
