using System;
using System.Collections.Generic;

namespace BandAid.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public ICollection<User> User { get; set; }
    }
}
