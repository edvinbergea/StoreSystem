using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StoreSystem
{
    internal class XmlHandler
    {
        private string xmlURL = "https://hex.cse.kau.se/~jonavest/csharp-api/";
        public XmlHandler() { }

        public List<UnifiedProd> GetXML() {
            WebClient client = new WebClient();
            var text = client.DownloadString(xmlURL);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            if (doc.FirstChild.ChildNodes.Item(0).Name == "error") {
                throw new Exception("Api: " + doc.FirstChild.ChildNodes.Item(0).InnerText); 
            }
            var products = new List<UnifiedProd>();
            foreach (XmlElement prod in doc.FirstChild.ChildNodes.Item(1).ChildNodes) 
            {
                products.Add(ExtractProd(prod));
            }
            return products;
        }

        private UnifiedProd ExtractProd(XmlElement prod)
        {
            var nprod = new UnifiedProd();
            nprod.type = prod.Name;
            foreach(XmlElement child in prod.ChildNodes)
            {
                var prop = typeof(UnifiedProd).GetProperty(child.Name);
                if (prop != null)
                {
                    var value = child.InnerText;
                    if (value != null)
                    {
                        prop.SetValue(nprod, value);
                    }
                }
            }
            return nprod;
        }
    }
}
