using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LM.IdentityService.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class IdentityController : ControllerBase
  {
    private static readonly string[] Identities = new[]
    {
      "frontend","tester","backend"
    };
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(Identities);
    }

  }
}
 
