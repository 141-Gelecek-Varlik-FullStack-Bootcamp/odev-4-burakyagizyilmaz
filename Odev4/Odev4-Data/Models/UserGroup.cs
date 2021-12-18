using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            GroupXroles = new HashSet<GroupXrole>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GroupXrole> GroupXroles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
