using ExercPropHerPolim.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercPropHerPolim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();

            System.Console.Write("Enter the number of products: ");
            int numProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, Used or imported? (c/u/i): "); // Atenção: Entrada não validada. Ambiente de Teste controlado apenas.
                string typeProduct = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (typeProduct == "i") // Imported
                {
                    Console.Write("Customs Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product importedProduct = new ImportedProduct(name, price, customFee);
                    listProduct.Add(importedProduct);
                }
                else if (typeProduct == "u") // Used
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product usedProduct = new UsedProduct(name, price, manufactureDate);
                    listProduct.Add(usedProduct);
                }
                else // Commom
                {
                    Product product = new Product(name, price);
                    listProduct.Add(product);
                }
            }
            // Mostrando os resultados
            Console.WriteLine("PRICE TAGS:");
            // List Products
            foreach (Product product in listProduct)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
