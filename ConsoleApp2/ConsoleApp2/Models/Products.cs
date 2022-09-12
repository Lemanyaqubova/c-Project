using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2.Models
{
    class Products
    {
            private string _name;
            private string _inqredint;
            private int _price;

            public int Id { get; set; }
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value != null)
                    {
                        _name = value;
                    }
                }
            }
            public string Inqredint
            {
                get
                {
                    return _inqredint;
                }
                set
                {
                    if (value != null)
                    {
                        _inqredint = value;
                    }
                }
            }
            public int Price
            {
                get
                {
                    return _price;
                }

                set
                {
                    if (value > 0)
                    {
                        _price = value;
                    }
                }
            }
            public static int ID()
            {
                List<Products> Products = new List<Products>();
                using (StreamReader sr = new StreamReader("C:\\Users\\lenovo\\Desktop\\Proyekt\\Project\\Project\\Files\\products.json"))
                {
                    Products = JsonConvert.DeserializeObject<List<Products>>(sr.ReadToEnd());
                }

                int max = 0;
                foreach (var item in Products)
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

