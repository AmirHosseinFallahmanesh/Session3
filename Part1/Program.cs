using System;

namespace Part1
{//ref  out
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("the number before method call is "+number);
            ChangeNumber(ref number);
            Console.WriteLine("the number after method call is "+number);
            Console.WriteLine();

            int[] numbers = new int[4] { 10, 20, 30, 40 };
            Console.WriteLine("the numbers[0] before method call is " + numbers[0]);
            ChangeNumbers(numbers);
            Console.WriteLine("the numbers[0] after method call is " + numbers[0]);

            Array.Resize(ref numbers, 10);

        }

        static void ChangeNumbers(int[] numbers)
        {
            numbers[0] = 20;
            Console.WriteLine("the numbers[0] inside methid is " + numbers[0]);
        }
        static void ChangeNumber(ref int number)
        {
            number = 20;
            Console.WriteLine("the number inside methid is "+number);
        }
    }
}
