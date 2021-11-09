using System;
using System.Collections.Generic;

namespace Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
        

            List<string> shoppingList = new List<string>()
            {
                "Apples",
                "Pears",
                "Bananas",
                "Watermelon"
            };

            string choice;
            do
            {
                Console.WriteLine("Welcome to Shopping List v1.0");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. View List");
                Console.Write("Enter Choice (X to exit): ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Item: ");
                        string newItem = Console.ReadLine();
                        shoppingList.Add(newItem);
                        break;
                    case "2":
                        foreach (string item in shoppingList)
                        {
                            Console.WriteLine($"{shoppingList.IndexOf(item)}. {item}");
                        }
                        Console.Write("Enter item number to delete: ");
                        int itemNumber = Convert.ToInt32(Console.ReadLine());
                        if (itemNumber < shoppingList.Count - 1)
                        {
                            shoppingList.RemoveAt(itemNumber);
                        }
                        break;
                    case "3":
                        foreach (string item in shoppingList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        Console.WriteLine("This is not a valid option.");
                        break;
                }
            } while (choice.ToUpper() != "X");
          
        }
    }
}
