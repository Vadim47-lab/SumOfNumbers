using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int three = 3;
            int five = 5;

            int number = random.Next(0, 100);

            Console.WriteLine("\n Рандомное число number = " + number);

            for (int i = 0; i <= number; i++)
            {
                if ((i % five == 0) || (i % three == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine("\n Cумма всех положительных чисел меньше number (включая число), которые кратные 3 или 5 - sum = " + sum);
        }
    }
}
