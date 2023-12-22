using System;
using System.Collections.Generic;
using System.Text;

namespace cofeeshop
{
    public class Coffee
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    // Represents a coffee shop with a menu and basic operations.
    public class CoffeeShop
    {
        private List<Coffee> menu;

        // Constructor initializes an empty menu.
        public CoffeeShop()
        {
            menu = new List<Coffee>();
        }

        // Adds a coffee item to the menu.
        public void AddCoffee(Coffee coffee)
        {
            menu.Add(coffee);
        }

        // Displays the current coffee menu to the console.
        public void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i].Name} - ${menu[i].Price:F2}");
            }
        }

        // Takes a customer's choice and processes the coffee order.
        public void OrderCoffee(int choice)
        {
            if (IsValidChoice(choice))
            {
                Coffee selectedCoffee = menu[choice - 1];
                Console.WriteLine($"You ordered {selectedCoffee.Name}. Enjoy your coffee!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }

        // Validates if the provided choice is within the valid range.
        private bool IsValidChoice(int choice)
        {
            return choice >= 1 && choice <= menu.Count;
        }
    }

}
