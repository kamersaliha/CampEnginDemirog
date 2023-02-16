using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //naming convention
        public void Add(Product x)
        {
            Console.WriteLine("Sepete eklendi:" + x.Name);
        }
        public void Add2(string productName,string productDescription, double price, int stokAdedi) 
        {
            Console.WriteLine("Sepete eklendi : " + productName);
        }
    }
}
