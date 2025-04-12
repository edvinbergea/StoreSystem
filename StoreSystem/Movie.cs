using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal class Movie : Product
    {
        public string format { get; set; }
        public string playtime { get; set; }

        public Movie(string Id, string Name, string Price, string Format, string Playtime, string Quantity, string Type)
        {
            id = Id;
            name = Name;
            price = Price;
            format = Format;
            playtime = Playtime;
            quantity = Quantity;
            type = Type;
        }
    }
}
