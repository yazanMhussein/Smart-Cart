using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCartApplication.ShoppingCartApplication
{
    public class Product
    {
        public enum ProductCategory
        {
            Food,
            Clothing,
            Electronics,
            Cars,
            Toys,
            CoffeeMugs
        }
        public class ProductSetup
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public ProductCategory Category { get; set; }

            public ProductSetup(string name,decimal price, ProductCategory category)
            {
                Name = name;
                Price = price;
                Category = category;    
            }
            public override string ToString() 
            {
                return $"{Category}:- {Name} = ${Price} ";
            }
            
        }
    }
}
