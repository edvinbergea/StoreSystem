using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal abstract class Product
    {
        public bool isValid { get; set; } = true;
        public string name { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string type { get; set; }
        public string id { get; set; }

    }
}
