using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCartApplication.ShoppingCartApplication
{
    public class ShoppingCart
    {
        private List<Product.ProductSetup> productsItems;

        public ShoppingCart()
        {
            productsItems = new List<Product.ProductSetup>();
        }

        public void AddproductsItems(Product.ProductSetup product)
        {
            productsItems.Add(product);
        }

        public void RemoveproductsItems(Product.ProductSetup product)
        {
            productsItems.Remove(product);
        }

        public List<Product.ProductSetup> GetproductsItems()
        {
            return productsItems;
        }

        public decimal GetTotalCost()
        {
            return productsItems.Sum(productItem => productItem.Price);
        }
    }
}

