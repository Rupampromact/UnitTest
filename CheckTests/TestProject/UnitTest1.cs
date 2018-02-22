using System;
using System.Collections.Generic;
using CheckTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountProducts()
        {
            var products = new List<Product>{
            new Product( "lettuce",10.5,50,"Leafy green"),
            new Product("cabbage",20,100,"Cruciferous"),
            new Product("pumpkin", 30,30, "Marrow"),
            new Product( "cauliflower", 10 , 25, "Cruciferous"),
            new Product( "zucchini", 20.5 , 50, "Marrow"),
            new Product( "yam", 30 , 50, "Root"),
            new Product( "spinach", 10 , 100, "Leafy green"),
            new Product( "broccoli", 20.2, 75, "Cruciferous"),
            new Product( "Garlic", 30 , 20, "Leafy green"),
            new Product( "silverbeet", 10 , 50, "Marrow")
            };
            ProductRepository p = new ProductRepository(products);
            int c = p.NumberOfProducts(products);
            Assert.AreEqual(10, c);
        }
        [TestMethod]
        public void AddProducts()
        {
            var products = new List<Product>{
            new Product( "lettuce",10.5,50,"Leafy green"),
            new Product("cabbage",20,100,"Cruciferous"),
            new Product("pumpkin", 30,30, "Marrow"),
            new Product( "cauliflower", 10 , 25, "Cruciferous"),
            new Product( "zucchini", 20.5 , 50, "Marrow"),
            new Product( "yam", 30 , 50, "Root"),
            new Product( "spinach", 10 , 100, "Leafy green"),
            new Product( "broccoli", 20.2, 75, "Cruciferous"),
            new Product( "Garlic", 30 , 20, "Leafy green"),
            new Product( "silverbeet", 10 , 50, "Marrow")
            };
            ProductRepository p = new ProductRepository(products);
            p.NewList("Potato", 10, 20, "Root");
            int count = p.NumberOfProducts(products);
            Assert.AreEqual(11, count);
            //p.DeleteByName(list, "Potato");
        }
        [TestMethod]
        public void DeleteProducts()
        {
            var products = new List<Product>{
            new Product( "lettuce",10.5,50,"Leafy green"),
            new Product("cabbage",20,100,"Cruciferous"),
            new Product("pumpkin", 30,30, "Marrow"),
            new Product( "cauliflower", 10 , 25, "Cruciferous"),
            new Product( "zucchini", 20.5 , 50, "Marrow"),
            new Product( "yam", 30 , 50, "Root"),
            new Product( "spinach", 10 , 100, "Leafy green"),
            new Product( "broccoli", 20.2, 75, "Cruciferous"),
            new Product( "Garlic", 30 , 20, "Leafy green"),
            new Product( "silverbeet", 10 , 50, "Marrow")
            };
            ProductRepository p = new ProductRepository(products);
           
            p.DeleteByName("zucchini");
            p.DeleteByName("broccoli");
            int c1 = p.NumberOfProducts(products);
            Assert.AreEqual(8,c1);
        }
        [TestMethod]
        public void AddProduct1()
        {
            var products = new List<Product>{
            new Product( "lettuce",10.5,50,"Leafy green"),
            new Product("cabbage",20,100,"Cruciferous"),
            new Product("pumpkin", 30,30, "Marrow"),
            new Product( "cauliflower", 10 , 25, "Cruciferous"),
            new Product( "zucchini", 20.5 , 50, "Marrow"),
            new Product( "yam", 30 , 50, "Root"),
            new Product( "spinach", 10 , 100, "Leafy green"),
            new Product( "broccoli", 20.2, 75, "Cruciferous"),
            new Product( "Garlic", 30 , 20, "Leafy green"),
            new Product( "silverbeet", 10 , 50, "Marrow")
            };
            ProductRepository p = new ProductRepository(products);
            var list = p.NewList("Radish", 10, 20, "Root");
            int count = p.NumberOfProducts(list);
            Assert.AreEqual(11, count);
            //p.DeleteByName(list, "Potato");
        }

        public void AddProduct2()
        {
            var products = new List<Product>{
            new Product( "lettuce",10.5,50,"Leafy green"),
            new Product("cabbage",20,100,"Cruciferous"),
            new Product("pumpkin", 30,30, "Marrow"),
            new Product( "cauliflower", 10 , 25, "Cruciferous"),
            new Product( "zucchini", 20.5 , 50, "Marrow"),
            new Product( "yam", 30 , 50, "Root"),
            new Product( "spinach", 10 , 100, "Leafy green"),
            new Product( "broccoli", 20.2, 75, "Cruciferous"),
            new Product( "Garlic", 30 , 20, "Leafy green"),
            new Product( "silverbeet", 10 , 50, "Marrow")
            };
            ProductRepository p = new ProductRepository(products);
            p.NewList("Carrot", 5, 100, "Root");
            int count = p.NumberOfProducts(products);
            
            
        }
    }
    }
