using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MyPractice
{
    class Class1
    {
        public int Multi()
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


        public void Read(string textFile)
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
        public List<string> Iteration()
        {
            List<string> ls = new List<string>(10);
            ls.Add("one");
            ls.Add("two");
            ls.Add("three");
            ls.Add("four");

            return ls;
        }
    }

}
