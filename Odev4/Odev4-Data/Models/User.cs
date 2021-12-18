using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class User
    {
        public User()
        {
            ProductCreatedByNavigations = new HashSet<Product>();
            ProductLastModifiedByNavigations = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserGroupId { get; set; }

        public virtual UserGroup UserGroup { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigations { get; set; }
        public virtual ICollection<Product> ProductLastModifiedByNavigations { get; set; }
    }
}
