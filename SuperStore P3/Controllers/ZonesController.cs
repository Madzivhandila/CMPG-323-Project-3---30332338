using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EcoPower_Logistics.Repository; // Import the Products Repository namespace

namespace EcoPower_Logistics.Controllers
{
    [Route("api/zones")]
    [ApiController]
    public class ZonesController : ControllerBase
    {
        private readonly CustomerRepository customerRepository; // Inject the Customers Repository

        public ZonesController(CustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet("customers/{customerId}")]
        public ActionResult GetCustomer(int customerId)
        {
            try
            {
                var customer = customerRepository.GetCustomerById(customerId);
                return Ok(customer);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("customers")]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            var customers = customerRepository.GetAllCustomers();
            return Ok(customers);
        }
    }
}
