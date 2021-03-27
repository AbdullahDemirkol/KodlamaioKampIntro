using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",UnitPrice=10000,UnitsInStock=7},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",UnitPrice=8000,UnitsInStock=5},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",UnitPrice=6000,UnitsInStock=3},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",UnitPrice=5000,UnitsInStock=8},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",UnitPrice=8000,UnitsInStock=0},
            };

            Console.WriteLine("------------Algoritmik------------");
            foreach (var item in products)
            {
                if (item.UnitPrice>6000)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            Console.WriteLine("------------Linq------------");
            var result = products.Where(p => p.UnitPrice > 6000).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            GetProducts(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var item in products)
            {
                if (item.UnitPrice > 6000)
                {
                    filteredProducts.Add(item);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 6000).ToList();
        }
    }
    
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
