using System;
using System.Collections.Generic;

#nullable disable

namespace Odev4_Data.Models
{
    public partial class GroupXrole
    {
        public int GroupId { get; set; }
        public int RoleId { get; set; }

        public virtual UserGroup Group { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
