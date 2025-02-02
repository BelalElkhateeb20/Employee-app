using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //<class modifiers> →(public,internal(default),
    public class Employee
    {
        public static double TAX = .03;
        //<Access modifier> public ,private,protected
        public  string Fname;
        public  string Lname;
        public  double Wage;
        public  double LoggedHours;
        public Employee()
        {}
        private double caluc_salary() => Wage * LoggedHours;                     //if the method contains one line we dont need→{}
        private double caluc_TAXamount() =>   caluc_salary() * Employee.TAX;       //if the method contains one line we dont need→{}
        private double caluc_netsalary() => caluc_salary() - caluc_TAXamount();    //if the method contains one line we dont need→{}
        public  string display()
        {
            return
                   $"\nMy name is : {Fname}" +
                   $"\nMy name is : {Lname}" +
                   $"\nwage :{Wage}" +
                   $"\nloogedhour :{LoggedHours}" +
                   $"\nsalary is : {caluc_salary()}" +
                   $"\nDeductable TAX ({Employee.TAX * 100}%)  Amount : {caluc_salary()}" +
                   $"\nNetsalary is : {caluc_netsalary()}" +
                   "\n-----------------------\n";
        }

    }
}
