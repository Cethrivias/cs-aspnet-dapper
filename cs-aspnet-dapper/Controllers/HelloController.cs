using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace cs_aspnet_dapper.Controllers
{
  public class HelloResponse
  {
    public string Hello { get; set; }
  }

  [ApiController]
  [Route("hello")]
  public class HelloController : ControllerBase
  {
    [HttpGet]
    public async Task<HelloResponse> Get([FromServices] Db db)
    {
      return await db.Connection.QueryFirstAsync<HelloResponse>("select @Text as Hello", new { Text = "World!" });
    }
  }
}