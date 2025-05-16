using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LM.UserService.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {
    private static readonly string[] Users = new[]
    {
      "xhuyz1","xhuyz2","xhuyz3"
    };

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(Users);
    }

  }
}
 
