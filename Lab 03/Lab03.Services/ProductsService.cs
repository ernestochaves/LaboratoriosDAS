using Lab03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Services
{
    /// <summary>
    /// Contains the methods that 
    /// </summary>
    public class ProductsService
    {
        public ProductsService()
        {
            //Fake initialization of a products list, 
            //this should come from a database
            Products = new List<Product>();
            for (int i = 0; i < 30; i++)
            {
                Products.Add(new Product(i, "Product #" + i, "###" + i + " Description", (decimal)i));
            }
        }

        /// <summary>
        /// This is our fake repository of data
        /// </summary>
        public List<Product> Products { get; set; }

        public List<Product> GetProducts()
        {
            return Products;
        }

        /// <summary>
        /// Inserts the new product to the underlying store
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="Description"></param>
        /// <param name="value"></param>
        public void AddProduct(int id, string name, string description, decimal price)
        {
            Products.Add(new Product(id, name, description, price));
        }

        /// <summary>
        /// Remove a product from the underlying data store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        public void RemoveProduct(int id)
        {
            Products.RemoveAll(a => a.Id == id);
        }
    }
}
