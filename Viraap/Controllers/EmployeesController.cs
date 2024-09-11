using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vira.Technical.Interview.Models.Classes;
using Vira.Technical.Interview.Models.Entites;
using Viraap.Data;

namespace Vira.Technical.Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        #region DbContext

        //Constructor injection : 
        private readonly AppDbContext _dbContext;
        public EmployeesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Get

        [HttpGet]
        public async Task<ActionResult<EmploymentResponse>> GetEmploymentStatus([FromBody] Employee employee)
        {
            _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();

            var response = new EmploymentResponse();//Because the answers were the same, I wrote in the constructor

            return Ok(response);
        }

        #endregion

        #region Description
        //سوال یک مقدار مبهم بود چون در متد "get"
        //شما ورودی داده بودین به دلیل همین منفرایند سیو کردن 
        //همکار رو اینجا پیاده سازی کردم وگرنه مثل متد "post"
        //میشد با یک ریسپانس بعد از اضافه کردن متن مورد نظر نمایش داده شود
        #endregion
    }
}
