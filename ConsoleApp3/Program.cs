using ConsoleApp3;
using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            Employee[] emps = new Employee[2];
            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());
            Employee ob1 = new ();
            Console.Write("enter you fname : ");
            ob1.Fname = Console.ReadLine();
            Console.Write("enter you Lname : ");
            ob1.Lname = Console.ReadLine();
            Console.Write($"wage :");
            ob1.Wage = Convert.ToDouble(Console.ReadLine());
            Console.Write($"loogedhour :");
            ob1.LoggedHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************");
            emps[0] = ob1;

            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Employee ob2 = new();
            Console.Write("enter you fname : ");
            ob2.Fname = Console.ReadLine();
            Console.Write("enter you Lname : ");
            ob2.Lname = Console.ReadLine();
            Console.Write($"wage :");
            ob2.Wage = Convert.ToDouble(Console.ReadLine());
            Console.Write($"loogedhour :");
            ob2.LoggedHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("******************");
            emps[1] = ob2;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.ReadKey();
            //Program ob1 = new Program();

            //var a = 10;
            //when we want it witout initalization we put (out)befor int age and  
            //ob1.num_calc(a);//by value
            //ob1.num_calco(ref a);//by reference 
            //Console.WriteLine(a);//by value
            //Console.WriteLine( a);//by reference 
            //    var number = "123345d";
            //    int num;
            //    if (int.TryParse(number, out num)) { Console.WriteLine($"valid num {num}"); }
            //    else
            //    {

            //        Console.WriteLine("not valid number");
            //    }
            //    Console.ReadKey();

            //}
            //public void num_calc (int age)
            //    {
            //    age = age + 10;
            //    }
            //public void num_calco (ref int age)
            //    {
            //    age= age + 10;

            //    }
        }
    }
}
