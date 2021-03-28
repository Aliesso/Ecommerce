using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order:BaseEntity
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmmount { get; set; }
        public string OrderCode { get; set; }
        public DateTime PlacedOn { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
    }
}
