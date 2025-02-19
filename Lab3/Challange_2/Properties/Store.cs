using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.Properties
{
    public class Store
    {
        public static List<Store> Products = new List<Store>();
        public string PName { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int MinQuantity { get; set; }
        public Store()
        {

        }
        public Store(string name, string category, float price, int Q, int minQ)
        {
            PName = name;
            Category = category;
            Price = price;
            Quantity = Q;
            MinQuantity = minQ;
        }


        public bool AddProduct(Store product)
        {
            Products.Add(product);
            return true;
        }
        public void ViewAllProducts()
        {
            Console.Clear();
            foreach (Store product in Products)
            {
                Console.WriteLine($"Product Name: {product.PName}, Category: {product.Category}, Price: {product.Price}, Total Quantity: {product.Quantity}, Min.Quantity: {product.MinQuantity}");
            }
        }
        public void HighestPriceProduct()
        {
            int max_idx = 0;
            for(int i = 1; i < Products.Count; i++)
            {
                if (Products[i].Price > Products[max_idx].Price)
                {
                    max_idx = i;
                }
            }
            Console.Clear();
            Console.WriteLine($"Product Name: {Products[max_idx].PName}, Category: {Products[max_idx].Category}, Price: {Products[max_idx].Price}, Total Quantity: {Products[max_idx].Quantity}, Min.Quantity: {Products[max_idx].MinQuantity}");
        }
        public void SalesTaxOfProduct()
        {
            Console.Clear();
            float tax = 0.0F;
            foreach(Store product in Products)
            {
                tax = 15.0F;
                if(product.Category == "grocery")
                {
                    tax = 10.0F;
                }
                else if(product.Category == "fruit")
                {
                    tax = 5.0F;
                }

                Console.WriteLine($"Product Name: {product.PName}, Category: {product.Category}, Tax: {product.Price * (tax/100.0F)}");
            }
        }

        public void ProductToBeOrdered()
        {
            Console.Clear();
            foreach (Store product in Products)
            {
                if(product.Quantity < product.MinQuantity)
                {
                    Console.WriteLine($"Product Name: {product.PName}, Quantity: {product.Quantity}, Min.Quantity: {product.MinQuantity}");
                }
            }
        }
    }
}
