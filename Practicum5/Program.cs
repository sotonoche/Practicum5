using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum5
{
    internal class Program
    {
        static double f(double x)
        {
            double y = Math.Sqrt(5 - Math.Pow(x, 3));
            if ((5 - Math.Pow(x, 3)) < 0) throw new Exception();
            return y;
        }
        
        static void Main(string[] args)
        {
            double a, b, h;
            while (true)
            {
                try
                {
                    Console.Write("Введите значение a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение h: ");
                    h = double.Parse(Console.ReadLine());
                    if (h == 0.0) throw new Exception("Шаг не может быть равен нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное значение!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Значения фунции на промежутке от {a} до {b} с шагом {h}");
            Console.WriteLine("x\ty");
            for (double i = a; i <= b; i += h)
            {
                try
                {
                    Console.WriteLine($"{i}\t{Math.Round(f(i), 3)}");
                }
                catch (Exception)
                {
                    Console.WriteLine($"{i}\tПри данном значении х, значение под корнем будет отрицательным!");
                }
            }
        }
    }
}
