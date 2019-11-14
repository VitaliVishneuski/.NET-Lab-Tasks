using System;
using System.Linq;
using System.Text;

namespace SumApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            do
            {
                Console.WriteLine("Введите целое число:");
                if (int.TryParse(Console.ReadLine(), out var integer))
                {
                    double sum = 0;
                    for (var number = 0; number <= integer; number++)
                    {
                        sum += number;
                    }
                    Console.WriteLine($"Сумма целых чисел от 0 до {integer} = {(int)sum}");
                }
            } while (true);
        }
    }
}
