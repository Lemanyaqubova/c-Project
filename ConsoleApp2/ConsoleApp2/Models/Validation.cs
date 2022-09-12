using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2.Models
{
    class Validation
    {
        
        public static bool LoginIsAllow(string username)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                return true;
            }
            return false;
        }
        public static bool PasswordIsAllow(string password)
        {
            if (password.Length >= 6 && password.Length <= 16 && HasDigit(password)&&HasLower(password)&&HasUpper(password))
            {
                return true;
            }
            return false;
        }
        public static bool NameIsAllow(string name)
        {
            if (name.Length >= 3 && name.Length <= 18)
            {
                return true;
            }
            return false;
        }
        public static bool SurnameIsAllow(string surname)
        {
            if (surname.Length >= 3 && surname.Length <= 18)
            {
                return true;
            }
            return false;
        }
        public static bool CheckLogin(List<User> users, string username)
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Users.json"))
            {
                users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
            }
            User user = users.Find(u => u.Username == username);
            if (user != null)
            {
                return true;
            }
            return false;
        }
        private static bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 47 && word[i] < 58)
                {
                    return true;
                }

            }
            return false;
        }
        private static bool HasUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 64 && word[i] < 91)
                {
                    return true;
                }

            }
            return false;

        }
        private static bool HasLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 96 && word[i] < 123)
                {
                    return true;
                }

            }
            return false;
        }
    }
	
    
}
