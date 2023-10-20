using DataAccses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace DataAccses
{
    public class EmployeeDataAccses 
    {
        // csv (comma seperated Value) => Product.csv


        public ObservableCollection<Employee> employees { get; set; } = new ObservableCollection<Employee>();



        public EmployeeDataAccses()
        {
            Reademployees();



        }

        private void Reademployees()
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                FisrtName = "hesmat",
                LastName = "heshamt por",
                PhoneNumber = 09121212121,
                Address = "tehran",
                Departmentprop =  Employee.Department.Production,
                BaseSalary = 2500
                
            };

            Employee emp2 = new Employee()
            {
                Id = 2,
                FisrtName = "MEhran",
                LastName = "Modiri",
                PhoneNumber = 090145248885,
                Address = "tehran",
                Departmentprop = Employee.Department.Management,
                BaseSalary = 3600

            };

            employees.Add(emp1);
            employees.Add(emp2);
        }
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void RemoveEmployee(int Id)
        {
            Employee temp = employees.First(x => x.Id == Id);
            employees.Remove(temp);
        }
        public void EditEmployee(Employee emp)
        {
            Employee temp = employees.First(x => x.Id == emp.Id);
            int index = employees.IndexOf(temp);
            employees[index] = emp;
        }

        public int GetNextId()
        {
            int index = employees.Any() ? employees.Max(x => x.Id) + 1 : 1;
            return index;
        }
    }
}

