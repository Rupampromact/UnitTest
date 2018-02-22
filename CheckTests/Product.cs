using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTests
{
    public class Product
    {
        public String name;
        public double price;
        public int quantity;
        public String type;
       

        public Product(String name, double price, int quantity, String type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
    }
}
