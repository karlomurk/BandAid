using System;
using System.Collections.Generic;

namespace BandAid.Models
{
    public partial class Status
    {
        public Status()
        {
            Event = new HashSet<Event>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }

        public ICollection<Event> Event { get; set; }
    }
}
