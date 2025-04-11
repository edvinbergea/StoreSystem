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

        public Movie(int Id, string Name, int Price, string Format, string Playtime, int Quantity, string Type)
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
