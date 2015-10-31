using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RSVP
    {
        public int RSVPId { get; set; }
        public int EventId { get; set; }
        public Guid ConfimationNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public bool isAttending { get; set; }
        public int AttendingGuests { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string ShortDescription { get; set; }
        public string FavoriteWine { get; set; }
    }
}
