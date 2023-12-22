using System;

namespace cofeeshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the coffee shop and add coffee items to the menu.
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.AddCoffee(new Coffee { Name = "Espresso", Price = 2.5m });
            coffeeShop.AddCoffee(new Coffee { Name = "Latte", Price = 3.0m });
            coffeeShop.AddCoffee(new Coffee { Name = "Cappuccino", Price = 3.5m });

            // Main loop for interacting with the coffee shop.
            while (true)
            {
                coffeeShop.DisplayMenu();

                try
                {
                    Console.Write("Enter the number of the coffee you'd like to order (0 to exit): ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 0)
                    {
                        break;
                    }

                    coffeeShop.OrderCoffee(choice);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
