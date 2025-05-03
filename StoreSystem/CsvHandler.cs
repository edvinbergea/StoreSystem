using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal class CsvHandler
    {
        private string csvPath = "..\\..\\Resources\\database.csv";
        private string testPath = "..\\..\\Resources\\test.csv";
        public CsvHandler() { }

        private UnifiedProd ParseLIne(string[] header, string[] line) { 
            var product = new UnifiedProd();
            foreach (var h in header) {
                var prop = typeof(UnifiedProd).GetProperty(h);
                if (prop != null)
                {
                    var value = line[Array.IndexOf(header, h)];
                    if (value != null)
                    {
                        prop.SetValue(product, value);
                    }
                }
            }
            return product;
        }

        public List<UnifiedProd> LoadProds()
        {
            var products = new List<UnifiedProd>();
            using (var reader = new StreamReader(csvPath))
            {
                string[] header = null;
                string line;
                if(!reader.EndOfStream) { header = reader.ReadLine().Split(','); }
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values.Length > 0)
                    {
                        var product = ParseLIne(header, values);
                        
                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public void SaveProds(List<UnifiedProd> products)
        {
            using (var writer = new StreamWriter(csvPath))
            {
                var propArray = typeof(UnifiedProd).GetProperties();
                List<string> headers = new List<string>();
                foreach (var prop in propArray)
                {
                    headers.Add(prop.Name.ToString());
                }
                writer.WriteLine(string.Join(",", headers));
                foreach (var p in products)
                {
                    var values = new List<string>();
                    foreach (var prop in propArray)
                    {
                        var value = prop.GetValue(p);
                        if (value != null)
                        {
                            values.Add(value.ToString());
                        }
                    }
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }
    }
}
