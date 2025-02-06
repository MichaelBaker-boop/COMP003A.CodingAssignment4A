// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory managament application with a minimum of 10 elements in the collection.

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuSelection;
            List<string> productNames = new List<string>();
            List<int> productQuantities = new List<int>();

            bool menu = true;
            while (menu)
            {
                // Create a menu and ask for choice from user
                Console.WriteLine("Menu: ");
                Console.WriteLine("1) Add a Product.");
                Console.WriteLine("2) Update Product Quantity.");
                Console.WriteLine("3) View Inventory Summary.");
                Console.WriteLine("4) Exit.");

                try
                {
                    Console.Write("Enter the number of your choice: ");
                    menuSelection = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");

                    throw;
                }

                if (menuSelection == 1)
                {
                    Console.WriteLine("Name of product: ");
                    productNames.Add(Console.ReadLine());

                    Console.WriteLine("Enter the amount of product:");
                    productQuantities.Add(int.Parse(Console.ReadLine()));

                    Console.WriteLine("Product Added Successfully!\n");
                }
                
                if (menuSelection == 2)
                {
                    Console.WriteLine("Enter the name of the product to update its quantity:");
                    int index = productNames.IndexOf(Console.ReadLine());
                    if (index != -1)
                    {
                        Console.WriteLine("Enter the new amount of product:");
                        productQuantities[index] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Product updated successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Product Not Found.\n");
                    }
                }

                if (menuSelection == 3)
                {
                    Console.WriteLine("Inventory Summary:");
                }

                if (menuSelection == 4)
                {
                    menu = false;
                }

            }


        }
    }
}