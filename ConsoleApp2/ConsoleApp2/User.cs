using ConsoleApp2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public object Name { get; internal set; }
        public object Surname { get; internal set; }
        public int Id { get; set; }

        public static int UserID()
        {
            List<Users> users = new List<Users>();
            using (StreamReader sr = new StreamReader("C:\\Users\\Leman\\OneDrive\\Desktop\\C# Project\\ConsoleApp2\\ConsoleApp2\\Files\\Users.json"))
            {
                users = JsonConvert.DeserializeObject<List<Users>>(sr.ReadToEnd());
            }
            int max = 0;
            foreach (Users item in users)
            {
                if (item.Id > max)
                {
                    max = item.Id;
                }
            }
            return max + 1;
        }
    }
}