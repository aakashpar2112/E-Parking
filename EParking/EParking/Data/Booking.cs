using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EParking.Data
{
    public class Booking
    {
        
        [Key]
        public int Bid { get; set; }


        [ForeignKey("CustID")]
        public int CustID { get; set; }

        [ForeignKey("ServiceID")]
        public int ServiceID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string ParkingBookService { get; set; } = string.Empty;
        [Required]
        public DateTime BookingDate { get; set; }

    }
}
