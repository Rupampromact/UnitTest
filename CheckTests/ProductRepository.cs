using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTests
{
    public class ProductRepository
    {

        List<Product> products = new List<Product>();
        
       public ProductRepository (List<Product> product)
        {
            this.products = product;
        }
        
        public int NumberOfProducts(List<Product> products)
        {
            return products.Count;
        }
        public List<Product> NewList(String n, double p, int q, String t)
        {

            products.Add(new Product(n, p, q, t));
            return products;

            // NumberOfProducts();
        }
        public List<Product> TypeCheck(String type)
        {

            var typed = products.Where(x => x.type == type).ToList();
            return typed;
        }
        public List<Product>DeleteByName(String name)
        {
            /*int counter = products.Count;
            for(int i=0;i<counter;i++)
            {
                if(products[i].name==name)
                {
                    products.RemoveAt(i);
                    break;
                }
            }*/
            var p = products.RemoveAll(x => x.name == name);
            return products;
        }
        public double BuyProducts(String name, int quantity)
        {
            var found = products.Where(X => X.name == name).ToList();
            double total = 0;
            foreach (var c in found)
                total = total + (quantity * c.price);
            return total;


        }
    }
}
