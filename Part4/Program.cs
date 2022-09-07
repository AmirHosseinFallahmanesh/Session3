using System;
using System.Collections.Generic;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("amir");
            names.Add("reza");
            names.Add("sina");
            names.Add("mahya");
            names.Add("saman");

            names[1] = "ali";
            Console.WriteLine("the lenght is "+names.Count);

            for (int i = 0; i < names.Count; i++)
            {
                //names[i]
            }

            //names.Remove("sina");
            //names.RemoveAt(3);
            //names.Clear();
            names.Contains("mahya"); //exist true , false
            //names.Sort();
            //names.Reverse();
            //string[] a=names.ToArray();

            Console.WriteLine(names.IndexOf("qolli")); ;


        }
    }
}
