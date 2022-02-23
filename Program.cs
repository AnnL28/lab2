using System;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            RomanNumber n1 = new RomanNumber(12);
            Console.WriteLine(n1);

            RomanNumber n2 = new RomanNumber(10);
            Console.WriteLine(n1);

            RomanNumber n3 = (RomanNumber)n1.Clone();
            Console.WriteLine(n3);

            RomanNumber dif0 = RomanNumber.Sub(n1, n3);
            Console.WriteLine(dif0);

            RomanNumber sum = RomanNumber.Add(n1, n2);
            Console.WriteLine(sum);

            RomanNumber dif = RomanNumber.Sub(n1, n2);
            Console.WriteLine(dif);

            RomanNumber mult = RomanNumber.Mul(n1, n2);
            Console.WriteLine(mult);

            RomanNumber div = RomanNumber.Div(n1, n2);
            Console.WriteLine(div);

            RomanNumber[] numbers = { n1, n2 };
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
        }
    }
}
