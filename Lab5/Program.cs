using System;
using System.Collections.Generic;
using Customer;
using Order;

namespace Customer
{
    class Cust
    {
        public string CustName { get; set; }
        
        public bool getName()
        {
            Console.Write("Please enter your name: ");
            CustName = Console.ReadLine();
            return true;
        }
    }       
}

namespace Order
{
    class GroceryItem
    {
        public void OrderGrocery()
        {
            Cust objCust1 = new Cust();
            objCust1.getName();
            Console.WriteLine("Hello {0}", objCust1.CustName);
            Console.WriteLine("You have ordered grocery items.");
        }
    }

    class BakeryProduct
    {
        public void OrderBakery()
        {
            Cust objCust2 = new Cust();
            objCust2.getName();
            Console.WriteLine("Hello {0}", objCust2.CustName);
            Console.WriteLine("You have ordered bakery product.");
        }
    }
}

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What would you like to order ?");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1, Grocery Item.");
                Console.WriteLine("2, Bakery Product.");
                Console.WriteLine("3, Quit.");
                Console.WriteLine("------------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    GroceryItem item = new GroceryItem();
                    item.OrderGrocery();
                    break;
                }
                else
                {
                    if (choice == 2)
                    {
                        BakeryProduct product = new BakeryProduct();
                        product.OrderBakery();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter again only 1 or 2 !");
                    }
                }

                if (choice == 3)
                {
                    Console.WriteLine("Have a nice day!");
                    break;
                }
            }
        }
    }
}
