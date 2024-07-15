using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartCartApplication.ShoppingCartApplication.Product;

namespace SmartCartApplication.ShoppingCartApplication
{
    public class CarsStore
    {
        private List<ProductSetup> products;

        public CarsStore(int numberOfProducts)
        {
            products = new List<ProductSetup>();
            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(ProductGenerator.GenerateProduct(ProductCategory.Cars));
            }
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Available products in Car Store:");
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
