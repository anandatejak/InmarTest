using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Offer
    {
        public Offer()
        {

        }
        public Offer(List<Product> products,string offerName)
        {
            Products = products;
            OfferName = offerName;
        }
        public List<Product> Products { get; }
        public string OfferName { get; }
    }
}