using DataAccses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DataAccses
{
    public class CustomerDataAccses
    {
        public ObservableCollection<Customer> customers { get; set; } = new ObservableCollection<Customer>();



        public CustomerDataAccses()
        {
            Readcustomers();

        }

        private void Readcustomers()
        {
            Customer cst1 = new Customer()
            {
                Id = 1,
                FisrtName = "Reza",
                LastName = "Mohammad por",
                PhoneNumber = 09121212121,
                Address = "Italy",
                

            };

            Customer cst2 = new Customer()
            {
                Id = 2,
                FisrtName = "Mohammad ",
                LastName = "akbari",
                PhoneNumber = 090145248885,
                Address = "bosher",
                

            };

            customers.Add(cst1);
            customers.Add(cst2);
        }
        public void AddCustomer(Customer cst)
        {
            customers.Add(cst);
        }
        public void RemoveCustomer(int id)
        {
            Customer temp = customers.First(x => x.Id == id);
            customers.Remove(temp);
        }
        public void EditCustomer(Customer cst)
        {
            Customer temp = customers.First(x => x.Id == cst.Id);
            int index = customers.IndexOf(temp);
            customers[index] = cst;
        }

        public int GetNextId()
        {
            int index = customers.Any() ? customers.Max(x => x.Id) + 1 : 1;
            return index;
        }
    }

}

