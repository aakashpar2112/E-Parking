using System.ComponentModel.DataAnnotations;


namespace EParking.Data
{
    public class ServiceProviderRegistration
    {

        [Key]
        public int ServiceID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
       
        public int PhoneNo { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string ParkingType { get; set; } = string.Empty;
        [Required]
        public int ParkingPrice { get; set; }
       



        //public bool Status { get; set; } 

       /* public virtual Customer? Customer { get; set; }*/


    }
}
