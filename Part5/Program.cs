using System;
using System.Collections.Generic;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)Add Name");
                Console.WriteLine("2)Edit Name");
                Console.WriteLine("3)Delete Name");
                Console.WriteLine("4)Print Name");
                Console.WriteLine("5)Exit");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            names.Add(name);
                            Console.WriteLine(" Add Operation Done!");
                            Console.ReadKey();

                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string search = Console.ReadLine();

                            int index=names.IndexOf(search);
                            if (index!=-1)
                            {
                                Console.WriteLine("Enter New Name");
                                names[index] = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Name Not Found");
                            }
                          
                            Console.ReadKey();

                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string search = Console.ReadLine();

                            int index = names.IndexOf(search);
                            if (index != -1)
                            {
                                names.RemoveAt(index);
                            }
                            else
                            {
                                Console.WriteLine("Name Not Found");
                            }

                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < names.Count; i++)
                        {
                                Console.WriteLine(names[i]);
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        return;

                    default:
                        Console.WriteLine("input invalid");
                        break;
                }
            }

        }
    }
}
