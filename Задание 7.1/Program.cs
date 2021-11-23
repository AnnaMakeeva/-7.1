using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите стороны первого треугольника");//вывод в консоль
            int a1 = Convert.ToInt32(Console.ReadLine());            //создаем переменные 1-го треугольника
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            

            double S1;
            GetS(a1, b1, c1, out S1);
            Console.WriteLine("Введите стороны второго треугольника");//вывод в консоль
            int a2 = Convert.ToInt32(Console.ReadLine());            //создаем переменные 2-го треугольника
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            double S2;
            GetS(a2, b2, c2, out S2);

            if (S1 > S2)
            {
                Console.WriteLine("Первый больше"); 
            }
            else Console.WriteLine("Второй больше"); 




            Console.ReadKey();

        }

        static void GetS(int a1, int b1, int c1, out double S1)
        {
            double P1 = (a1 + b1 + c1)/2;                             //находим полупериметр
            S1 = Math.Sqrt(P1 * (P1 - a1) * (P1 - b1) * (P1 - c1));  //находим площадь
            
            
        }

  
    }
}
