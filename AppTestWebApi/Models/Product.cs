using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTestWebApi.Models
{
    public class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public String category { get; set; }
        public long? price { get; set; }
    }
}