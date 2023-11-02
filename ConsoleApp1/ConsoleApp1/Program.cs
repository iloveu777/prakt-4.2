using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double x1,y1,x2,y2,x3,y3;
            Write("Введите x1: " );
            x1 = int.Parse(ReadLine() );
            Write("Введите y1: ");
            y1 = int.Parse(ReadLine());
            Write("Введите x2: ");
            x2 = int.Parse(ReadLine());
            Write("Введите y2: ");
            y2 = int.Parse(ReadLine());
            Write("Введите x3: ");
            x3 = int.Parse(ReadLine());
            Write("Введите y3: ");
            y3 = int.Parse(ReadLine());
            double ab, bc, ac;
            ab = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            bc = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            ac = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double s_half = (ab + bc + ac) / 2;
            double s = Math.Sqrt(s_half * (s_half-ab) * (s_half -bc) * (s_half - ac));
            double p = ab + ac + bc;
            WriteLine($"Площадь = {s:f1}, периметр = {p:f1}");
            */
            /*
            int s, b ,c;
            Write("введите расстояние: ");
            s = int.Parse(ReadLine());
            Write("введите расход на 100км:");
            b = int.Parse(ReadLine());
            Write("стоимость бензина:");
            c = int.Parse(ReadLine());
            int price = s / 100 * b * c;
            WriteLine($"стоимость = {price:c}"); 
            */

            double z,x,y;
            Write("цена конфет за кг: ");
            z = double.Parse(ReadLine());
            Write("цена печенья за кг:");
            x = double.Parse(ReadLine());
            Write("цена яблок за кг:");
            y = double.Parse(ReadLine());
            Clear();
            double p1, p2, p3;
            Write("сколько кг конфет: ");
            p1 = double.Parse(ReadLine());
            Write("сколько кг печенья: ");
            p2 = double.Parse(ReadLine());
            Write("сколько кг яблок: ");
            p3 = double.Parse(ReadLine());
            Clear();
            double price = (x * p1) + (y * p2) + (z * p3);
            WriteLine($"стоимость всего:{price:c}");
            ReadKey();
        }
    }
}
