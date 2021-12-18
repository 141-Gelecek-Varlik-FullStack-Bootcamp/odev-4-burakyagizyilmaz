using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class Image
    {
        public Image()
        {
            ProductXimages = new HashSet<ProductXimage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoLink { get; set; }

        public virtual ICollection<ProductXimage> ProductXimages { get; set; }
    }
}
