﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccses.Models;
using System.Collections.ObjectModel;

namespace DataAccses
{
    public class ProductDataAccses
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();



        public ProductDataAccses() 
        {
            ReadProducts();
            

        
        }

        private void ReadProducts()
        {
            Product pr1 = new Product()
            {
                Id = 1,
                Name = "animal farm",
                Author = "george orwell",
                AvailableCount = 12,
                Price = 17
            };

            Product pr2 = new Product()
            {
                Id = 2,
                Name = "brave new world",
                Author = "Aldous Huxley",
                AvailableCount = 5,
                Price = 34


            };

            Products.Add(pr1);
            Products.Add(pr2);
        }
        public void AddProducts(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(int id)
        {
            Product temp = Products.First(x => x.Id == id);
            Products.Remove(temp);
        }
        public void EditProduct(Product product)
        {
            Product temp = Products.First(x => x.Id == product.Id);
            int index = Products.IndexOf(temp);
            Products[index] = product;
        }

        public int GetNextId()
        {
            int index =Products.Any() ?  Products.Max(x => x.Id)+1:1;
            return index;
        }
    }
}
