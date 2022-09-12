using ConsoleApp2;
using ConsoleApp2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PizzaProject.Models
{
    class Crud
    {
        public static List<User> GetInfoUser()
        {
            List<User> users = new List<User>();
            using (StreamReader sr = new StreamReader("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Users.json"))
            {
                users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
            }
            return users;
        }
        public static List<User> WriterUser(List<User> users)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Users.json"))
            {
                sw.Write(JsonConvert.SerializeObject(users));
            }
            return users;
        }
        public static List<Products> GetInfoProducts()
        {
            List<Products> products = new List<Products>();
            using (StreamReader sr = new StreamReader("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Products>>(sr.ReadToEnd());
            }
            return products;
        }
        public static List<Products> WriteProducts(List<Products> products)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Products.json"))
            {
                sw.Write(JsonConvert.SerializeObject(products));
            }
            return products;
        }
        public static List<User> UserDelete(int id)
        {
            List<User> users = GetInfoUser();
            users.Remove(users.SingleOrDefault(x => x.Id == id));
            Crud.WriterUser(users);
            return users;
        }
        public static void PrintProduct()
        {
            List<Products> products;
            using (StreamReader sr = new StreamReader("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Products.json"))
            {
                products = JsonConvert.DeserializeObject<List<Products>>(sr.ReadToEnd());
            }
            foreach (Products item in products)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Inqredint + " " + item.Price);

            }
        }


    }
}
    



