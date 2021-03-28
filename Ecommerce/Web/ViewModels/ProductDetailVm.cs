using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class ProductDetailVm
    {
        public Product Product { get; set; }
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> SameCategories { get; set; }
    }
}
