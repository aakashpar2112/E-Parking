
using Microsoft.EntityFrameworkCore;

namespace EParking.Data
{
    public class CustomerDBContext : DbContext
    {

        public CustomerDBContext()
        {
        }
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
                   : base(options)
        { }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<ServiceProviderRegistration> ServiceProviderRegistrations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
       




    }
}


