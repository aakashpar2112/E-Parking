using System.ComponentModel.DataAnnotations;

namespace EParking.Data
{
    public class Customer
    {
      /*  public Customer()
        {
            ServiceProviderRegistrations = new HashSet<ServiceProviderRegistration>();
        }*/

        [Key]
        public int CustID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        public long PhoneNo { get; set; }

        [Required]
        public string Email { get; set; } = string.Empty;

       /* public virtual ICollection<ServiceProviderRegistration> ServiceProviderRegistrations { get; set; }*/
    }
}
