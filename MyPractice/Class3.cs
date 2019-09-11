using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
    public class Class3
    {
         string firstname;
         string lastname;
         string location;
         int salary;
        
        List<string> li = new List<string>();

        public void list()
        {
            
            
            Console.WriteLine("Enter First Name ");
            firstname = Console.ReadLine();
            li.Add(firstname.ToUpper());
            Console.WriteLine("enter last name ");
            lastname = Console.ReadLine();
            li.Add(lastname.ToUpper());
            Console.WriteLine("Enter Location ");
            location = Console.ReadLine();
            li.Add(location.ToUpper());
            Console.WriteLine("Give Salary ");
            string salary = Console.ReadLine();
             li.Add(salary);
        }
        public void menu1()
        {
            bool exit = true;
            do
            {
                Console.WriteLine("Enter 1 for adding new member");
                Console.WriteLine("Enter 2 for List all members ");
                Console.WriteLine("Enter 3 for search");
                Console.WriteLine("Enter 4 for exit");

                string input1 = Console.ReadLine();
                int value4 = Convert.ToInt32(input1);
                switch (value4)
                {
                    case 1:
                        
                        list();
                        Console.WriteLine("Below the List of items you have added");
                        foreach (object obj in li)
                        {
                            Console.WriteLine(obj);
                        }

                        break;
                    case 2:
                        iter();
                        break;

                    case 3:
                        Console.WriteLine("enter item for search ");
                        string sear = Console.ReadLine();
                        if (li.Contains(sear.ToUpper()))
                        {
                            Console.WriteLine("Item FOund");

                        }
                        else
                        {
                            Console.WriteLine("Item not Found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Good bye have a good day");
                        exit = false;
                        break;

                }
            } while (exit);
        }
        public void iter()
        {
            foreach (object li2 in li)
            {
                Console.WriteLine(li2);
            }
        }

        
    }
}
