using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Models
{
    public class Employee : IPerson
    {
        public int Id { get ; set ; }
        public string FisrtName { get ; set ; }
        public string LastName { get ; set ; }
        public ulong PhoneNumber { get; set; }
        public string Address { get; set; }

        public Department Departmentprop { get; set; }

        public decimal BaseSalary {  get; set; }


        public string GetBasicInfo()
        {
            string FinaSTR = FisrtName + " " + LastName +
                "\nTell: " + PhoneNumber +
                "\nAddress" + Address +
                "\nDepartment" + Departmentprop +
                "\nBase Salary" + BaseSalary;
            return FinaSTR;

        }

        public enum Department
        {
            Production,
            Sales,
            Advertisement,
            Management,

        }
    }
}
