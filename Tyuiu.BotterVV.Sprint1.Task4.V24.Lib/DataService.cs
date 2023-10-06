using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BotterVV.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            double a = x * y;
            var chisl = Math.Log(a);
            var znam = x + Math.Pow((2 * Math.Pow(y, 2)), 0.5);
            var res = Math.Round(chisl / znam, 3);
            return res;
        }
    }
}
