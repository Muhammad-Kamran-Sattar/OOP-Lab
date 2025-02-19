using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Challange_2.Properties;

namespace Challange_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opt = "0";
            while (opt != "6")
            {
                opt = StoreOpt();
                if (opt == "1")
                {
                    string name, category;
                    float price;
                    int quantity, minquantity;
                    Console.Clear();
                    Console.Write("Enter the Name of product: ");
                    name = Console.ReadLine();
                    Console.Write("Enter the category(grocery/fruit/other): ");
                    category = Console.ReadLine();
                    Console.Write("Enter the price of product: ");
                    price = float.Parse(Console.ReadLine());
                    Console.Write("Enter the total quantity of product: ");
                    quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Minimum quantity of product: ");
                    minquantity = int.Parse(Console.ReadLine());

                    Store product = new Store(name, category, price, quantity, minquantity);
                    if(product.AddProduct(product))
                    {
                        Console.WriteLine("Product has been successfully stored");
                    }
                    Console.ReadKey();
                }
                else if (opt == "2")
                {
                    Store product = new Store();
                    product.ViewAllProducts();
                    Console.ReadKey();
                }
                else if (opt == "3")
                {
                    Console.WriteLine("Press any key to find product with highest Unit Price.!!");
                    Console.ReadKey();
                    Store product = new Store();
                    product.HighestPriceProduct();
                    Console.ReadKey();
                }
                else if (opt == "4")
                {
                    Console.WriteLine("Press any key to find tax on each product.!!");
                    Console.ReadKey();
                    Store product = new Store();
                    product.SalesTaxOfProduct();
                    Console.ReadKey();
                }
                else if (opt == "5")
                {
                    Console.WriteLine("Press any key to display the products to be ordered.!!");
                    Console.ReadKey();
                    Store product = new Store();
                    product.ProductToBeOrdered();
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Program Ended.");
             
        }
        static string StoreOpt()
        {
            string opt;
            Console.Clear();
            Console.WriteLine("=== Welcome to Departmental Store ===");
            Console.WriteLine("1) Add Product");
            Console.WriteLine("2) View All Product");
            Console.WriteLine("3) Find Product with the Highest Unit Price");
            Console.WriteLine("4) View Sales Tax of All Products");
            Console.WriteLine("5) Show Products to be Ordered");
            Console.WriteLine("6) Exit Program");

            Console.Write("\n Enter your option(1/2/3/4/5/6): ");
            opt = Console.ReadLine();
            return opt;
        }
    }
}
