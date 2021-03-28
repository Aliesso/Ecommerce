using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class FilterProductsVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public int? CategoryID { get; set; }
        public int? SortBy { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
