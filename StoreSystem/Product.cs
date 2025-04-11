using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal abstract class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string type { get; set; }
        public int id { get; set; }

    }
}
