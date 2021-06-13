using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class Menu1
    {
        public string message { get; set; }
        public List<Item> data { get; set; }
    }

    class Item1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }
}
