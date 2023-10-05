using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BotterVV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            int rub = 0;
            if (((Convert.ToInt32(number % 1)) * 10) < 5)
            {
                rub = (Convert.ToInt32(number) / 1);
            }

            if (((Convert.ToInt32(number % 1)) * 10) >= 5)
            {
                rub = ((Convert.ToInt32(number) / 1) - 1);
            }

            return rub;
   
        }
    }

    public class DataService1 : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {   
            int kop;
            kop = Convert.ToInt32((Convert.ToDouble(number) % 1) * 100);

            return kop;

        }
    }
}
