using System;
using System.Collections.Generic;

namespace BandAid.Models
{
    public partial class User
    {
        public User()
        {
            Event = new HashSet<Event>();
            Review = new HashSet<Review>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PassHash { get; set; }
        public string Description { get; set; }
        public string ProfileImg { get; set; }
        public int RoleId { get; set; }
        public bool IsEmailVerified { get; set; }
        public Guid ActivationCode { get; set; }

        public UserRole Role { get; set; }
        public ICollection<Event> Event { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}
