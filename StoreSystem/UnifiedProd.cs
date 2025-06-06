﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    public class UnifiedProd
    {
        public string name { get; set; }
        public string price { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public string format { get; set; }
        public string language { get; set; }
        public string platform { get; set; }
        public string playtime { get; set; }
        public string stock { get; set; }
        public string type { get; set; }
        public string id { get; set; }

        public UnifiedProd(string Id, string Name, string Price, string Author, string Genre, string Format, string Language, string Platform, string Playtime, string Stock, string Type)
        {
            id = Id;
            name = Name;
            price = Price;
            author = Author;
            genre = Genre;
            format = Format;
            language = Language;
            platform = Platform;
            playtime = Playtime;
            stock = Stock;
            type = Type;
        }
        public UnifiedProd() { 
            id = "-1";
            name = " ";
            price = " ";
            author = " ";
            genre = " ";
            format = " ";
            language = " ";
            platform = " ";
            playtime = " ";
            stock = " ";
            type = " ";
        }
    }

}
