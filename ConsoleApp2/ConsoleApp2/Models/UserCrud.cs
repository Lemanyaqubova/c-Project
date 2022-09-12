using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2.Models
{
    class UserCrud
    {
        public static void Registrstion(List<User> users)
        {
            nameiswrong:
            Console.WriteLine("Zehmet olmasa adinizi daxil edin ");
            string name = Console.ReadLine();
            Console.Clear();
            if (!Validation.NameIsAllow(name))
            {
                goto nameiswrong;
            }
            surnameiswrong:
            Console.WriteLine("Zehmet olmasa soyadinizi daxil edin ");
            string surname = Console.ReadLine();
            Console.Clear();
            if (!Validation.SurnameIsAllow(surname))
            {
                goto surnameiswrong;
            }
            loginiswrong:
            Console.WriteLine("Zehmet olmasa istifadeci adinizi daxil edin");

            samelogin:
            string login = Console.ReadLine();
            if (Validation.CheckLogin(users, login))
            {
                Console.Clear();
                Console.WriteLine("Bu ad artiq movcuddur, zehmet olmasa yenisini elave edin");
                goto samelogin;
            }
            Console.Clear();
            if (!Validation.LoginIsAllow(login))
            {
                goto loginiswrong;
            }
            passwordiswrong:
            Console.WriteLine("Zehmet olmasa parolunuzu daxil edin");
            string password = Console.ReadLine();
            Console.Clear();
            if (!Validation.PasswordIsAllow(password))
            {
                goto passwordiswrong;
            }
            users.Add(new User { Name = name, Surname = surname, Username = login, Password = password });

            using(StreamWriter sw = new StreamWriter("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Users.json"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(users));
            }
            Console.WriteLine("Qeydiyyat sona catdi");
                
        }

        
         
        
    }
}
