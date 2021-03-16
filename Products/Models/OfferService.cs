using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class OfferService
    {
        private List<Product> Inventory;
        public OfferService()
        {
            Inventory = FillInventory();
        }
        private List<Models.Product> FillInventory()
        {
            return new List<Models.Product>
            {
                new Product("P1",1000,"P1 Desc"),
                new Product("P2",200,"P2 Desc"),
                new Product("P3",400,"P3 Desc"),
                new Product("P4",700,"P4 Desc"),
                new Product("P5",600,"P5 Desc"),
                new Product("P6",800,"P6 Desc"),
            };
        }

        public  List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            return new List<Offer>
            {
                new Offer(Inventory.Take(3).ToList(),"ComboPackage1"),
                new Offer(Inventory.Take(3).ToList(),"ComboPackage2"),
                new Offer(Inventory.Take(3).ToList(),"ComboPackage3"),
                new Offer(Inventory.Take(3).ToList(),"ComboPackage4"),
            };
        }
    }
}