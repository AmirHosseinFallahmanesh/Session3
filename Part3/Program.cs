using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "amir,amiri,18";
            string[] info = data.Split(',');
            Console.WriteLine(info[0]);
            Console.WriteLine(info[1]);
            Console.WriteLine(info[2]);

            Console.WriteLine(data.StartsWith("am"));
            Console.WriteLine(data.EndsWith("am"));
            Console.WriteLine(data.Contains("am"));
        }
    }
}
