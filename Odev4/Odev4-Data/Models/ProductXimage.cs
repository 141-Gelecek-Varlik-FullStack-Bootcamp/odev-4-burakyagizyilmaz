using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class ProductXimage
    {
        public int ProductId { get; set; }
        public int ImageId { get; set; }

        public virtual Image Image { get; set; }
        public virtual Product Product { get; set; }
    }
}
