using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SecurityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Upload([FileExtensions(Extensions =".pdf,.txt")][MaxLength(10*1024)]IFormFile file)
        {
            ////Check File Extension
            //var extensions = Path.GetExtension(file.FileName);
            //if (extensions != ".pdf") return BadRequest("Only .pdf files are allowed");

            ////Check File Size
            //if(file.Length > 10 * 1024) return BadRequest($"File is larger than 10kb");

            //Generate a Random Name
            
            // Save the uploaded file to a temporary location
            var path = Path.GetTempFileName();
            using (var stream = System.IO.File.Create(path))
            {
                await file.CopyToAsync(stream);
            }

            // Do something with the uploaded file
            // ...

            return Ok("File uploaded");
        }
    }
}
