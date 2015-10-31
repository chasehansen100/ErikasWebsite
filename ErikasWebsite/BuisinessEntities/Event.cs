using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisinessEntities
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public DateTime EventDate { get; set; }
        public string Title { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public int GuestsAttending { get; set;}
    }
}
