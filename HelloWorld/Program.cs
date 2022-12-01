using System;
namespace Square
    {
        class Program
        {
            static void Main(string[] args)
                {
                Console.Write("Введите длину: ");
                int a =  Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ширину: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int x = a * b;
                if (a == b)
                    Console.WriteLine("Площадь квадрата равна: {0}" , x);
                else
                Console.WriteLine("Площадь прямоугольника равна: {0}", x);
                Console.WriteLine("---------------");
                Console.WriteLine("Пример цикла: ");
                Console.Write("Введите начальное число: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите конечное число: ");
                int d = Convert.ToInt32(Console.ReadLine());
                if (c <= d)
                {
                    while (c != d + 1)
                    {
                        Console.WriteLine(c);
                        c++;
                    }
                }
                else
                {
                    while (d != c + 1)
                    { 
                        Console.WriteLine(d);
                        d++;
                    }
                }
            }
        }
}

