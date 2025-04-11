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

        public Game(int Id, string Name, int Price, string Platform, int Quantity, string Type)
        {
            id = Id;
            name = Name;
            price = Price;
            platform = Platform;
            quantity = Quantity;
            type = Type;
        }
    }
}
