using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint3.TaskReview.V27.Lib;

namespace Tyuiu.UleevRI.Sprint3.TaskReview.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int l = ds.GetMassFunction(startValue, stopValue).Length;
            double[] num = new double[l];
            num = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= l - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,6:f2}   |", startValue, num[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.Write("[" + num[0] + ", " + num[1] + ", " + num[2] + ", " + num[3] + ", " + num[4] + ", " + num[5] + ", " + num[6] + ", " + num[7] + ", " + num[8] + ", " + num[9] + ", " +  num[10] + "]");
            Console.ReadKey();
        }
    }
}
