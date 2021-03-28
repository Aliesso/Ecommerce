﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderItem:BaseEntity
    {
        [NotMapped]
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal itemPrice { get; set; }
    }
}
