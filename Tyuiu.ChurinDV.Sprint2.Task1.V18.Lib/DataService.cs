using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

//int a = 155;
//int b = 696;
//int c = 242;
//int d = 541;


namespace Tyuiu.ChurinDV.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (b > a) | (a == c);
            res[1] = (b > c) & (a < d);
            res[2] = (a != d) || (d > b);
            res[3] = (c >= a) && (b == d);
            res[4] = !(res[3]);
            res[5] = (a != d) ^ (c <= b);

            return res;
        }
    }
}
