using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookingEvent.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [ForeignKey("Venue")]
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        [DisplayName("Booking Date")]
        [DataType(DataType.Date)]

        public DateTime BookingDate { get; set; }
    }
}
