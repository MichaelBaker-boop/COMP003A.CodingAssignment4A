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
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Invalid Input. Please enter a valid number.");
                    throw;
                }

                if (menuSelection == 1)
                {
                    Console.WriteLine("Name of product:");
                }

            }


        }
    }