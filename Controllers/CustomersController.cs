using Instient.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instient.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]

    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _CustomersRepository;

        public CustomersController(ICustomersRepository customersRepository)
        {
            _CustomersRepository = customersRepository;
        }

        [HttpGet]
        public ActionResult GetCustomers()
        {
            try
            {
                var customers = _CustomersRepository.GetCustomers();
                return Ok(customers);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
    }
}