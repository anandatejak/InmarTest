using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string productName,decimal price, string desc)
        {
            ProductName = productName;
            Price = price;
            Description = desc;
        }
        public string ProductName { get; }
        public decimal Price { get; }
        public string Description { get; }
    }
}