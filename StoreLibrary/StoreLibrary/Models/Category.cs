using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
