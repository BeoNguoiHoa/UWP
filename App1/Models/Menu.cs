using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class Menu
    {
        public string message { get; set; }
        public List<Item> data { get; set; }
    }

    class Item
    {
        public int id { get; set; }
        public string name { get; set; }

        public string image { get; set; }

        public string description { get; set; }

        public string price { get; set; }


    }
}
