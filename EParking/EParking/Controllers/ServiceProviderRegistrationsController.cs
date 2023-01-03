using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EParking.Data;

namespace EParking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProviderRegistrationsController : ControllerBase
    {
        private readonly CustomerDBContext _context;

        public ServiceProviderRegistrationsController(CustomerDBContext context)
        {
            _context = context;
        }

        // GET: api/ServiceProviderRegistrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceProviderRegistration>>> GetServiceProviderRegistrations()
        {
            return await _context.ServiceProviderRegistrations.ToListAsync();
        }

        // GET: api/ServiceProviderRegistrations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceProviderRegistration>> GetServiceProviderRegistration(int id)
        {
            var serviceProviderRegistration = await _context.ServiceProviderRegistrations.FindAsync(id);

            if (serviceProviderRegistration == null)
            {
                return NotFound();
            }

            return serviceProviderRegistration;
        }

        // PUT: api/ServiceProviderRegistrations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceProviderRegistration(int id, ServiceProviderRegistration serviceProviderRegistration)
        {
            if (id != serviceProviderRegistration.ServiceID)
            {
                return BadRequest();
            }

            _context.Entry(serviceProviderRegistration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceProviderRegistrationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ServiceProviderRegistrations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ServiceProviderRegistration>> PostServiceProviderRegistration(ServiceProviderRegistration serviceProviderRegistration)
        {
            _context.ServiceProviderRegistrations.Add(serviceProviderRegistration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceProviderRegistration", new { id = serviceProviderRegistration.ServiceID }, serviceProviderRegistration);
        }

        // DELETE: api/ServiceProviderRegistrations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceProviderRegistration(int id)
        {
            var serviceProviderRegistration = await _context.ServiceProviderRegistrations.FindAsync(id);
            if (serviceProviderRegistration == null)
            {
                return NotFound();
            }

            _context.ServiceProviderRegistrations.Remove(serviceProviderRegistration);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet]
        [Route("UserName,Password")]
        public IActionResult GetLogin(string UserName, string Password)
        {
            var customer = from s in _context.ServiceProviderRegistrations
                           where UserName == s.UserName && Password == s.Password
                           select s;
            if (customer.Count().Equals(0))
            {
                return Ok(false);
            }

            return Ok(customer);
        }
        private bool ServiceProviderRegistrationExists(int id)
        {
            return _context.ServiceProviderRegistrations.Any(e => e.ServiceID == id);
        }
    }
}
