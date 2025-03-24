using System.ComponentModel.DataAnnotations;

namespace BookingEvent.Models
{
    public class Login
    {
        //Login Model Class
        [Key]
        public int LoginId {  get; set; }
        [Required]
        public string Username {  get; set; }
        [Required]
        public string Password { get; set; }
    }
}
