// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory managament application with a minimum of 10 elements in the collection.

using System.Xml.Schema;

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuSelection = 0;
            List<string> productNames = new List<string>();
            List<int> productQuantities = new List<int>();

            Console.WriteLine("Welcome to the Inventory Management Application!");

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
                    Console.Write("Enter the number of your choice: \n");
                    menuSelection = int.Parse(Console.ReadLine());
                    if (menuSelection != 1 && menuSelection != 2 && menuSelection != 3 && menuSelection != 4) throw new Exception("Number must be between 1 and 4.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("The input was invalid.");
                    Console.WriteLine(e.Message);
                }



                if (menuSelection == 1)
                {
                    
                        Console.WriteLine("Name of product: ");
                        productNames.Add(Console.ReadLine());
                    try {
                        Console.WriteLine("Enter the amount of product:");
                        productQuantities.Add(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Product Added Successfully!\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("The input was invalid.");
                        Console.WriteLine(e.Message);

                    }
                }
                


                if (menuSelection == 2)
                {
                    Console.WriteLine("Enter the name of the product to update its quantity:");
                    int index = productNames.IndexOf(Console.ReadLine());
                    if (index != -1)
                    {
                        try
                        {
                            Console.WriteLine("Enter the new amount of product:");
                            productQuantities[index] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Product updated successfully!\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The input was invalid.");
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Product Not Found.\n");
                    }
                }



                if (menuSelection == 3)
                {
                    Console.WriteLine("Inventory Summary: ");
                    for (int i = 0; i < productNames.Count; i++)
                    {
                        Console.WriteLine($"{productNames[i]}"+$" {productQuantities[i]}\n");
                    }

                    double totalProducts = productNames.Count;
                    Console.WriteLine($"Total Products:{totalProducts} ");

                    double totalInventory = productQuantities.Sum();
                    Console.WriteLine($"Total Quantity:{totalInventory} ");

                    double averageInventory = totalInventory / totalProducts;
                    Console.WriteLine($"Average Quantity: {averageInventory} ");

                }



                if (menuSelection == 4)
                {
                    Console.WriteLine("Goodbye and have a wonderful day!");
                    menu = false;
                }

            }


        }
    }
}