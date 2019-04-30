using System;
using System.Collections.Generic;

namespace BandAid.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
       
    }
}
