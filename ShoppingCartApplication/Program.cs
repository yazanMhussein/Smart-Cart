using static SmartCartApplication.ShoppingCartApplication.Product;

namespace SmartCartApplication.ShoppingCartApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore(3);
            ClothingStore clothingStore = new ClothingStore(3);
            ElectronicsStore electronicsStore = new ElectronicsStore(3);
            CarsStore carsStore = new CarsStore(3);
            ToyStore toyStore = new ToyStore(3);
            MugStore mugStore = new MugStore(3);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. Shop at Electronics Store");
                Console.WriteLine("4. Shop at Cars Store");
                Console.WriteLine("5. Shop at Toy Store");
                Console.WriteLine("6. Shop at Mug Store");
                Console.WriteLine("7. View Shopping Cart");
                Console.WriteLine("8. Checkout and Exit");
                Console.Write("Select an option: ");
                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Shop(groceryStore, cart);
                        break;
                    case 2:
                        Shop(clothingStore, cart);
                        break;
                    case 3:
                        Shop(electronicsStore, cart);
                        break;
                    case 4:
                        Shop(carsStore, cart);
                        break;
                    case 5:
                        Shop(toyStore, cart);
                        break;
                    case 6:
                        Shop(mugStore, cart);
                        break;
                    case 7:
                        ViewCart(cart);
                        break;
                    case 8:
                        Console.WriteLine($"Total cost: ${cart.GetTotalCost()}");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void Shop(dynamic store, ShoppingCart cart)
        {
            store.DisplayProducts();
            Console.Write("Select a product to add to cart by index: ");
            int index;
            if (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }
            ProductSetup product = store.SelectProduct(index);
            if (product != null)
            {
                cart.AddproductsItems(product);
                Console.WriteLine("Product added to cart.");
            }
            else
            {
                Console.WriteLine("Invalid product selection.");
            }
        }

        static void ViewCart(ShoppingCart cart)
        {
            var items = cart.GetproductsItems();
            Console.WriteLine("Items in your cart:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}. {items[i]}");
            }

            Console.Write("Do you want to remove any item? (yes/no): ");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Console.Write("Enter the index of the item to remove: ");
                int index;
                if (!int.TryParse(Console.ReadLine(), out index))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }
                if (index >= 0 && index < items.Count)
                {
                    cart.RemoveproductsItems(items[index]);
                    Console.WriteLine("Item removed from cart.");
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }
            }
        }
    }
}

