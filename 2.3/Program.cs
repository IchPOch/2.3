using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введиете A, A<=B  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиете B, A<=B");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < a) Console.WriteLine("Неккоректный ввод");
            else
            {
                int g = a;
                while (g <= b)
                {
                    if (g > 0) Console.WriteLine(" " + g);
                    g++;
                }
                g = a;
                for (int i = a; i <= b; i++)
                {
                    if (i > 0) Console.WriteLine(" " + i);
                }
                do
                {
                    if (g > 0) Console.WriteLine(" " + g);
                    g++;
                }
                while (g <= b);
            }
        }
    }
}
