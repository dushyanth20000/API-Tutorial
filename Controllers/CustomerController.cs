using ApiTutorial.BusinessAccesLayer;
using ApiTutorial.Model.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IBusinessAcessLayer _businessAcessLayer;
        public CustomerController(IBusinessAcessLayer businessAcessLayer)
        {
                _businessAcessLayer = businessAcessLayer;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            List<Customers> customers=await _businessAcessLayer.Customers();
            if (customers == null || customers.Count == 0)
            {
                return NoContent(); // Returns a 204 No Content response when no customers are found.
            }

            return Ok(customers);
        }
    }
}
