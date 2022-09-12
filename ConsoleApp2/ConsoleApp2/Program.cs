using ConsoleApp2.Models;
using Newtonsoft.Json;
using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        //public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            List<User> users=new List<User>();
            users.Add(new User { Username = "admin", Password = "admin" });
            string a = JsonConvert.SerializeObject(users);
            using(StreamWriter sr = new StreamWriter("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Users.json"))
            {
                sr.Write(a);
            }

           
            LoginMenu:
            Console.WriteLine("1)Login");
            Console.WriteLine("2)Register");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);
            Console.Clear();
            Login:
            if (choice==1)
            {
                Console.WriteLine("Istifadeci adini daxil edin");
                string username = Console.ReadLine();
                Console.WriteLine("Parolunuzu daxil edin");
                string password = Console.ReadLine();

                User user = users.Find(u => u.Username == username && u.Password == password);
                if (user== null)
                {
                    Console.WriteLine("Username ve ya parol yalnisdir");
                    goto UserMenu;
                }
                Console.WriteLine($"isler tamamlandi { user.Name} { user.Surname}");
            }
            else if (choice == 2)
            {
                UserCrud.Registrstion(users);
                goto LoginMenu;
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun daxil edin ");
                goto LoginMenu;
            }
           
            UserMenu:
            List<Products> products = Crud.GetInfoProducts();
            Console.WriteLine("1)Pizzalara bax");
            Console.WriteLine("2)Sifaris ver");
            int choise1;
            int.TryParse(Console.ReadLine(), out choise1);
            if (choise1 == 1)
            {
                Crud.PrintProduct();
            }
            if (choise1 == 2)
            {

            }
            Console.WriteLine("Silmek istediyin userin id-ni daxil et");
            int id = int.Parse(Console.ReadLine());
            Crud.UserDelete(id);
        }                                                                    
    }
}
