using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MyPractice
{
    class Class1
    {
        public static int Multi()
        {
            Console.WriteLine("enter Count of Number ");
            string count = Console.ReadLine();
            int count1 = Convert.ToInt32(count);
            int result = 1;
            for (int i = 0; i < count1; i++)
            {
                
                Console.WriteLine("enter value ");
                string value12 = Console.ReadLine();
                int value121 = Convert.ToInt32(value12);
                result = value121 * result;

            }
           
           
            Console.WriteLine("result is");
            return result;
           
           
        }


        public static void Read(string textFile)
        {
            Console.WriteLine("enter the Directory name ");
            string dir = Console.ReadLine();
            string path1 = @"C:\\Users";
            Console.WriteLine("Enter user name");
            string path2 = Console.ReadLine();
            
            string combination = Path.Combine(path1, path2, dir);
            Directory.SetCurrentDirectory(combination);
            
            Console.WriteLine(combination);
           
            if (File.Exists(textFile))
            {
                Console.WriteLine("file Exists");
                string text3 = File.ReadAllText(textFile);
                Console.WriteLine(text3);
            }
            else
            {
                Console.WriteLine("file doesnot Exists");
            }
        }
        public static List<string> Iteration()
        {
            List<string> ls = new List<string>(10);
            ls.Add("one");
            ls.Add("two");
            ls.Add("three");
            ls.Add("four");

            return ls;
        }
        public void final()
        {
            bool exit = true;
            do

            {
                Console.WriteLine("1:For Multiplication");
                Console.WriteLine("2:For reading Text File");
                Console.WriteLine("3:for reading properties of a c# object");
                Console.WriteLine("4:For properies");
                Console.WriteLine("5:Exit");
                string input = Console.ReadLine();
                int value3 = Convert.ToInt32(input);

                switch (value3)
                {
                    case 1:
                        int result2 = Multi();
                        Console.WriteLine(result2);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("ENTER TEXT FILE NAME");
                        string filename = Console.ReadLine();

                        Read(filename);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("listIteration  is ");
                        List<string> range = Iteration();
                        foreach (string item in range)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("properties are ");
                        Type t = Type.GetType("MyPractice.Class1");
                        PropertyInfo[] properties1 = t.GetProperties();
                        Console.WriteLine(properties1);
                        foreach (PropertyInfo property in properties1)
                        {
                            Console.WriteLine("in loop");
                            Console.WriteLine(property.Name);
                            Console.WriteLine("in loop");
                        }
                        //m1.properties();
                        break;
                    case 5:
                        Console.WriteLine("Bye Have a Good Day");
                        Console.ReadLine();
                        exit = false;
                        break;


                }












            } while (exit);

        }
    }

}
