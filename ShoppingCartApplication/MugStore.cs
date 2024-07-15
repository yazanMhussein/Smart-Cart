using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartCartApplication.ShoppingCartApplication.Product;

namespace SmartCartApplication.ShoppingCartApplication
{
    public class MugStore
    {
        private List<ProductSetup> products;
        public MugStore(int numberOfProducts)
        {
            products = new List<ProductSetup>();
            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(ProductGenerator.GenerateProduct(ProductCategory.CoffeeMugs));
            }
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Available products in Mug Store:");
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
