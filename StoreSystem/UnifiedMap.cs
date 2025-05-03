using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    internal class UnifiedMap : ClassMap<UnifiedProd>
    {
        public UnifiedMap()
        {
            Map(m => m.name).Index(0);
            Map(m => m.price).Index(1);
            Map(m => m.author).Index(2);
            Map(m => m.genre).Index(3);
            Map(m => m.format).Index(4);
            Map(m => m.language).Index(5);
            Map(m => m.platform).Index(6);
            Map(m => m.playtime).Index(7);
            Map(m => m.stock).Index(8);
            Map(m => m.type).Index(9);
            Map(m => m.id).Index(10);
        }
    }
}
