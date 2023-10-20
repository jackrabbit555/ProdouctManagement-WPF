using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Models
{
    public interface IPerson
    {

     
        
        int Id { get; set; }
        string FisrtName { get; set; }
        string LastName {  get; set; } 
        UInt64 PhoneNumber {  get; set; }
        string Address {  get; set; }


        string GetBasicInfo();
        

    }
}
