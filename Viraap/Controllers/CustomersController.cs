using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vira.Technical.Interview.Models.Classes;
using Vira.Technical.Interview.Models.Entites;
using Viraap.Data;

namespace Viraap.Controllers
{
    // localhost:xxxx/api/Customers
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        #region DbContext

        //Because we inject the DbContext in the program.cs file, so we cane
        //accessed eny ware inside the application even in the controller.

        //Constructor injection : 
        private readonly AppDbContext _dbContext;
        public CustomersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        //We are going to add the Endpoint of operations:

        #region Post 

        [HttpPost]
        public async Task<ActionResult<RegistrationResponse>> RegisterCustomer([FromBody] Customer customer)
        {
            _dbContext.Customers.AddAsync(customer);
            await _dbContext.SaveChangesAsync();

            var response = new RegistrationResponse
            {
                Status = "OK",
                FullDes = $"{customer.Name} {customer.Family} با سن {customer.Age} در پایگاه داده ثبت شد."
            };

            return Ok(response);
        }

        #endregion  

        

    }
}
