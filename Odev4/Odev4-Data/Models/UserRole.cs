using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            GroupXroles = new HashSet<GroupXrole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }

        public virtual ICollection<GroupXrole> GroupXroles { get; set; }
    }
}
