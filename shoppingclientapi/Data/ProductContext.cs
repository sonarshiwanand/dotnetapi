using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using shoppingclientapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoppingclientapi.Data
{
    public class ProductContext
    {
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);

            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);

            SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }

        private static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool productExists = productCollection.Find(p => true).Any();

            if (!productExists)
            {
                productCollection.InsertManyAsync(GetProductsData());
            }
        }

        private static IEnumerable<Product> GetProductsData()
        {
            return new List<Product>() {

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
            },
            new Product(){
                Name = "Apple",
                Description ="Apple Phone",
                ImageFile="apple.png",
                Price = 150.00M,
                Category="Phone"
            }
            };
        }
    }
}
