using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace SecurityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{userId}")]
        public IActionResult GetUserById(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return BadRequest();

            string sql = "SELECT * FROM users WHERE id = @userId";
            using (SqlCommand cmd = new SqlCommand(sql, new SqlConnection()))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                //Excute command in here
                cmd.ExecuteReader();
            }

            return Ok();
        }
    }
}
