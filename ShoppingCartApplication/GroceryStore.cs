﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartCartApplication.ShoppingCartApplication.Product;

namespace SmartCartApplication.ShoppingCartApplication
{
    public class GroceryStore
    {
        private List<ProductSetup> products;

        public GroceryStore(int numberOfProducts)
        {
            products = new List<ProductSetup>();
            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(ProductGenerator.GenerateProduct(ProductCategory.Food));
            }
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Available products in Grocery Store:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public ProductSetup SelectProduct(int productNumbers)
        {
            if (productNumbers >= 0 && productNumbers < products.Count)
            {
                return products[productNumbers];
            }
            return null;
        }
    }
}
