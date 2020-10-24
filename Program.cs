using System;
using ProgressionLibrary;

namespace ConsoleProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression progr1 = new Progression();
            Console.WriteLine("Введите первый элемент и коэффициент прогрессии");
            progr1.Input();
            Progression progr2 = new Progression(1, 2);
            Console.WriteLine("Сумма прогрессий " + (progr1 + progr2));
            Console.WriteLine("Разность первой и второй прогрессии " + (progr1 - progr2));
            Console.WriteLine("Седьмой элемент второй прогрессии " + progr2[7]);
            if (progr1)
                Console.WriteLine("Прогрессия 1 возрастающая");
            else
                Console.WriteLine("Прогрессия 1 убывающая");
            Console.WriteLine("Прогрессии равны " + (progr1 == progr2));
            Console.WriteLine("Первый элемент прогрессии 2 " + (double)progr2);
            Console.WriteLine("Создадим 3 прогрессию с разностью 1 и первым элементом:");
            double d = Convert.ToDouble(Console.ReadLine());
            Progression progr3 = new Progression();
            progr3 = d;
            Console.WriteLine(progr3);
            Console.WriteLine("Умножим 3 прогрессию на 5 " + progr3 * 5);
        }
    }
}
