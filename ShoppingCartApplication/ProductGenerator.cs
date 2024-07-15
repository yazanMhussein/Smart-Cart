using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartCartApplication.ShoppingCartApplication.Product;

namespace SmartCartApplication.ShoppingCartApplication
{
    public class ProductGenerator
    {
        private static Random random = new Random();
        private static string[] foodName = { "Meat", "Rice", "Cake" };
        private static string[] clothingNames = { "Jacket", "TShirt", "Boots" };
        private static string[] electronicsNames = { "Mobile", "Laptop", "Tablet" };
        private static string[] carNames = { "Sedan", "SUV", "Convertible" };
        private static string[] toyNames = { "ActionFigure", "Doll", "Puzzle" };
        private static string[] mugNames = { "GlassMug", "TravelMug", "CeramicMug" };

        public static ProductSetup GenerateProduct(ProductCategory category)
        {
            
                //ProductCategory category = (ProductCategory)random.Next(Enum.GetValues(typeof(ProductCategory)).Length);
                string name;
                decimal price;
                switch (category)
                {
                    case ProductCategory.Food:
                        name = foodName[random.Next(foodName.Length)];
                        price = random.Next(1, 20);
                        break;
                    case ProductCategory.Clothing:
                        name = clothingNames[random.Next(clothingNames.Length)];
                        price = random.Next(10, 100);
                        break;
                    case ProductCategory.Electronics:
                        name = electronicsNames[random.Next(electronicsNames.Length)];
                        price = random.Next(100, 1000);
                        break;
                    case ProductCategory.Cars:
                        name = carNames[random.Next(carNames.Length)];
                        price = random.Next(10000, 70000);
                        break;
                    case ProductCategory.Toys:
                        name = toyNames[random.Next(toyNames.Length)];
                        price = random.Next(1, 20);
                        break;
                    case ProductCategory.CoffeeMugs:
                        name = mugNames[random.Next(mugNames.Length)];
                        price = random.Next(1, 10);
                        break;
                    default:
                        name = "Unknown";
                        price = 0;
                        break;
                }
                return new ProductSetup(name, price, category);
            }
        }
}

