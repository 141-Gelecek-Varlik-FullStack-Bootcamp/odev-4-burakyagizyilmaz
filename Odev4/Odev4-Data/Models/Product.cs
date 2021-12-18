using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductXimages = new HashSet<ProductXimage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? LastModifiedBy { get; set; }
        public double Price { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual User LastModifiedByNavigation { get; set; }
        public virtual ICollection<ProductXimage> ProductXimages { get; set; }
    }
}
