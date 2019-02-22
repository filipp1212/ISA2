using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    //public class Class1
    //{
    //}
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string firstName,string lastName,int salary)
        {
            FirstName = firstName;
            LastName = LastName;
            Salary = salary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
   
}
