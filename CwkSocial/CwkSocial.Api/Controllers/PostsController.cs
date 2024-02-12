using Cwk.Domain.Modles;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PostsController : Controller
    {

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var post = new Post { Id = id, Text= "Hallo, Dunia!!!"};
            return Ok(post);
        }
    }
}
