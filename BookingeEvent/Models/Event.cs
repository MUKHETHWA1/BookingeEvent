using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookingEvent.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        [DisplayName("Event Name")]
        public string EventName { get; set; }
        [Required]
        [DisplayName("Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        [DisplayName("Select Venue Here")]

        [ForeignKey("Venue")]
        public int? VenueId { get; set; }
        public Venue Venue { get; set; }
    }
}
