using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //created new list 
            List<employee> list = new List<employee>();
            //example for future reference
            //{

            //new employee() { FirstName = "Joe", LastName = "Francis", ID = 1},

            //};

            //added employees
            employee emp1 = new employee();
            emp1.FirstName = "Joe";
            emp1.LastName = "Francis";
            emp1.ID = 1;
            list.Add(emp1);

            employee emp2 = new employee();
            emp2.FirstName = "Joe";
            emp2.LastName = "Ronald";
            emp2.ID = 2;
            list.Add(emp2);

            employee emp3 = new employee();
            emp3.FirstName = "Joe";
            emp3.LastName = "Simmons";
            emp3.ID = 3;
            list.Add(emp3);

            employee emp4 = new employee();
            emp4.FirstName = "Joe";
            emp4.LastName = "Johnson";
            emp4.ID = 4;
            list.Add(emp4);

            employee emp5 = new employee();
            emp5.FirstName = "Jamie";
            emp5.LastName = "Schneider";
            emp5.ID = 5;
            list.Add(emp5);

            employee emp6 = new employee();
            emp6.FirstName = "Jack";
            emp6.LastName = "Parish";
            emp6.ID = 6;
            list.Add(emp6);

            employee emp7 = new employee();
            emp7.FirstName = "Ken";
            emp7.LastName = "Adams";
            emp7.ID = 7;
            list.Add(emp7);

            employee emp8 = new employee();
            emp8.FirstName = "Martha";
            emp8.LastName = "Kerr";
            emp8.ID = 8;
            list.Add(emp8);

            employee emp9 = new employee();
            emp9.FirstName = "Marjorie";
            emp9.LastName = "Peterson";
            emp9.ID = 9;
            list.Add(emp9);

            employee emp10 = new employee();
            emp10.FirstName = "Casey";
            emp10.LastName = "Green";
            emp10.ID = 10;
            list.Add(emp10);

            //creating new list to add the Joe employees
            List<employee> list2 = new List<employee>();

            //foreach loops to narrow down the Joes
            foreach (employee emp in list)
            {
                if (emp.FirstName == "Joe")
                {
                    //added Joes to list 2
                    list2.Add(emp);
                    Console.WriteLine("Employees with first name Joe = " + emp.FirstName + " " + emp.LastName);
                }
            }
            //lambda expression for Joes in the list
            List<employee> list3 = list.Where(x => x.FirstName == "Joe").ToList();
            foreach (employee j in list3)
            {
                Console.WriteLine(j.FirstName + " " + j.LastName);
            }


            //creating list with IDs greater than 5
            List<employee> eeList = list.Where(x => x.ID > 5).ToList();
            //loop to display which employees have an ID greater than 5
            foreach (employee e in eeList)
            {
                Console.WriteLine(e.FirstName);

            }
            Console.ReadLine();



        }
    }
}   

    

