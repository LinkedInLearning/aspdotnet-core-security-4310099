using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecurityApp.API.Models;

namespace SecurityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        public EmployeesController(IAuthorizationService authorizationService)
        {
            _authorizationService= authorizationService;
        }


        // GET: api/<EmployeesController>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "Manager")]
        [Authorize(Roles = "Employee")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeesController>
        [HttpPost]
        [Authorize(Policy = "SuperAdminOnly")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            User userDb = new User();

            //Check if LoggedIn User (Manager) can remove a user from the system
            var result = await _authorizationService.AuthorizeAsync(User, userDb, "HiringManager");
            if(result.Succeeded)
            {
                return Ok("User removed successfully");
            }
            return Forbid("You can not remove the user, because you are not the hiring manager.");
        }
    }
}
