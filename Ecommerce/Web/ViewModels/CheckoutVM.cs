using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class CheckoutVM
    {
        public List<Product> Products { get; set; }
        public List<int> ProductIDs { get; set; }
        public Task<K102User> K102Users { get; set; }
    }
}
