using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class TechItem
    {
        public string Name { get; set; }

        public static IEnumerable<TechItem> GetItems()
        {
            return new List<TechItem>
            {
                new TechItem {Name = "ASP" },
                new TechItem {Name = "ASP.NET" },
                new TechItem {Name = "ASP.NET Core" }
            };
        }
    }
}