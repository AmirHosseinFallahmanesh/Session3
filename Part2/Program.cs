using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
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
                            Array.Resize(ref names, names.Length + 1);
                            names[names.Length - 1] = name;
                            Console.WriteLine(" Add Operation Done!");
                            Console.ReadKey();

                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Name");
                            string search = Console.ReadLine();
                            bool find = false;
                            for (int i = 0; i < names.Length; i++)
                            {
                                if (names[i] == search)
                                {
                                    Console.WriteLine("Enter New Name");
                                    names[i] = Console.ReadLine();
                                    find = true;
                                    Console.WriteLine("Edit Operatin Done!");
                                }
                            }
                            if (!find)
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
                            bool find = false;
                            for (int i = 0; i < names.Length; i++)
                            {
                                if (names[i] == search)
                                {
                                    names[i] += "#";
                                    find = true;
                                    Console.WriteLine("Delete Operatin Done!");
                                }
                            }
                            if (!find)
                            {
                                Console.WriteLine("Name Not Found");

                            }
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (!names[i].EndsWith("#"))
                            {
                                Console.WriteLine(names[i]);
                            }
                           

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
