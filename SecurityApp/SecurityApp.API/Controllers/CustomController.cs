using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecurityApp.API.Filters;

namespace SecurityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKeyAuth]
    public class CustomController : ControllerBase
    {
    }
}
