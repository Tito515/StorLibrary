using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string UserNAme { get; set; }
        public string Role { get; set; }
    }
}
