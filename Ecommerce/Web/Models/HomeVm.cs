using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
