using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal class Book : Product
    {
        public string author { get; set; }
        public string genre { get; set; }
        public string format { get; set; }
        public string language { get; set; }

        public Book(int Id, string Name, int Price, string Author, string Genre, string Format, string Language, int Quantity,string Type)
        {
            id = Id;
            name = Name;
            price = Price;
            author = Author;
            genre = Genre;
            format = Format;
            language = Language;
            quantity = Quantity;
            type = Type;
        }
    }
}
