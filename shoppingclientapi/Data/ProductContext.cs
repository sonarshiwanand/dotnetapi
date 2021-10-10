using shoppingclientapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingclientapi.Data
{
    public static class ProductContext
    {

        public static readonly List<Product> Products = new List<Product>
        {
            new Product(){
                Name = "Nokia",
                Description ="Nokia Phone",
                ImageFile="nokia.png",
                Price = 100.00M,
                Category="Phone"
            },
            new Product(){
                Name = "Samsung",
                Description ="Samsung Phone",
                ImageFile="samsung.png",
                Price = 100.00M,
                Category="Phone"
            }
        };
    }
}
