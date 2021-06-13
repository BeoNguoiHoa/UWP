using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{

    class Home
    {
        public string message { get; set; }
        public List<HomeMenu> data { get; set; }
    }
    class HomeMenu
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    
}
