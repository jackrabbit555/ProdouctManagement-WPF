using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Models
{
    public class Product : IProduct
    {
        public int Id { get  ; set ; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int AvailableCount { get; set; }

        public string GetBasicInfo()
        {
            string FinalSTR = Name +
                "\nAuthor:" + Author +
                ".\nPrice:" + Price +
                "$ .\nAvailable Count:" + AvailableCount;
            return FinalSTR;
        }
    }
}
