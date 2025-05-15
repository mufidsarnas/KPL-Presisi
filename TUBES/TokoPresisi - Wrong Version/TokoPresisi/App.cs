using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoPresisi
{
    class App
    {
        static void Main(string[] args)
        {
            ArrayList productList = new ArrayList();

            // Add products to the ArrayList
            productList.Add(new ModelProduct(1, "Laptop", 999.99m, 10));
            productList.Add(new ModelProduct(2, "Smartphone", 699.99m, 25));
            productList.Add(new ModelProduct(3, "Headphones", 149.99m, 50));
            productList.Add(new ModelProduct(4, "Mouse", 24.99m, 100));

            // Display all products
            Console.WriteLine("Product List:");
            foreach (ModelProduct product in productList)
            {
                Console.WriteLine(product);
            }

            // Access a specific product
            if (productList.Count > 0)
            {
                Console.WriteLine("\nFirst Product:");
                Console.WriteLine(productList[0]);
            }

            // Remove a product
            productList.RemoveAt(1); // Removes the second product (index 1)

            Console.WriteLine("\nAfter removal:");
            foreach (ModelProduct product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }
}
