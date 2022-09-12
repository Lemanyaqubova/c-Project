using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Registration
    {
        private string _name;
        private string _surname;
        private string _username;
        private string _password;

        public string Username
        {
            get
            { 
                return _name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 16)
                {
                    _name = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length>=6 && value.Length<= 16)
                {
                    _password = value;
                }
            }
        }
        private bool HasDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]>47 && word[i]<58)
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]>96 && word[i]<123)
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasUpper(string word)
        {
            for (int i = 0; i <word.Length; i++)
            {
                if (word[i]>64 && word[i]<91)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
