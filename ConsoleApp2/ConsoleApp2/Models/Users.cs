using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Users
    {
        private static int _id;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public Users()
        {
            _id++;
            Id = _id;
        }
    }
}
                                                                                       
