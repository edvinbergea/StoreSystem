using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal class Game : Product
    {
        public string platform { get; set; }

        public Game(string Id, string Name, string Price, string Platform, string Quantity, string Type)
        {
            id = Id;
            name = Name;
            price = Price;
            platform = Platform;
            stock = Quantity;
            type = Type;
        }
    }
}
