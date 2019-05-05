using System;
using System.Collections.Generic;

namespace BandAid.Models
{
    public partial class Event
    {

        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }

        public Status Status { get; set; }
        public User User { get; set; }
    }
}
