using Lab03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ProductsService();
            System.Console.WriteLine("GET ALL PRODUCTS");
            var allProducts = service.GetProducts();

            foreach (var product in allProducts)
            {
                System.Console.WriteLine(string.Format("Id: {0}, Name: {1}, Price: ${2:0}", product.Id, product.Name, product.Price));
            }

            System.Console.WriteLine("Add product 100!!!");

            service.AddProduct(100, "A real name", "Real description", 1000);

            foreach (var product in allProducts)
            {
                System.Console.WriteLine(string.Format("Id: {0}, Name: {1}, Price: ${2:0}", product.Id, product.Name, product.Price));
            }

            System.Console.WriteLine("Remove product 100!!!");

            service.RemoveProduct(100);

            foreach (var product in allProducts)
            {
                System.Console.WriteLine(string.Format("Id: {0}, Name: {1}, Price: ${2:0}", product.Id, product.Name, product.Price));
            }

            System.Console.ReadKey();

        }
    }
}
