using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductPicture
    {
        public int ID { get; set; }
        public int PictureID { get; set; }
        public virtual Picture Picture { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
