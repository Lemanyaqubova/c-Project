using ConsoleApp2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PizzaProject.Models
{
    class ProductCrud
    {


        public static void Add()
        {
            string name = Console.ReadLine();
            string inqredint = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = Products.ID() , });
            using (StreamWriter sw = new StreamWriter("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }

        }
        public static void PrintProduct()
        {
            List<Products> products;
            using (StreamReader sr = new StreamReader("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Products>>(sr.ReadToEnd());
            }
            foreach (Products item in products)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Inqredint + " " + item.Price);

            }
        }
        public static List<Products> WriterProduct(List<Products> products)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }
            return products;
        }
        public static List<Products> GetInfoProduct()
        {
            List<Products> products = new List<Products>();
            using (StreamReader sr = new StreamReader("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Products>>(sr.ReadToEnd());
            }
            return products;
        }
        public static List<Products> ProductDelete(int id)
        {
            List<Products> products = GetInfoProduct();
            products.Remove(products.SingleOrDefault(x => x.Id == id));
            ProductCrud.WriterProduct(products);
            return products;
        }
    }
 }      