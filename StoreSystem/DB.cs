using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;

namespace StoreSystem
{
    internal class DB
    {
        public List<Product> productList;
        
        public DB() {
            productList = new List<Product>();
            FillList();
        }

        private void FillList()
        {
            using (var reader = new StreamReader("..\\..\\Resources\\database.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var rows = csv.GetRecords<dynamic>();

                    foreach (var row in rows)
                    {
                        string type = row.type;

                        Product product;
                        switch (type)
                        {
                            case ("book"): product = new Book(Int32.Parse(row.id), row.name, Int32.Parse(row.price), row.author, row.genre, row.format, row.language, Int32.Parse(row.quantity), row.type); break;
                            case ("game"): product = new Game(Int32.Parse(row.id), row.name, Int32.Parse(row.price), row.platform, Int32.Parse(row.quantity), row.type); break;
                            case ("movie"): product = new Movie(Int32.Parse(row.id), row.name, Int32.Parse(row.price), row.format, row.play_time, Int32.Parse(row.quantity), row.type); break;
                            default: product = null; break;
                        };
                        if (productList != null)
                        {
                            productList.Add(product);
                        }
                    }
                }
            }
        }
    }
}
