using System;

namespace DebugLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine($"Итерация номер: {i}");

                int divisor = arr[i];
                Console.WriteLine($"Взяли делитель из arr[{i}]: << {divisor}");

                int result = 100 / i;
                if (i != i)
                {
                    Console.WriteLine($"Результат: {result}");
                }
            }
        }
    }
}
