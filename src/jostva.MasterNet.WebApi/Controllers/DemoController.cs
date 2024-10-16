using Microsoft.AspNetCore.Mvc;

namespace jostva.MasterNet.WebApi.Controllers;

[ApiController]
[Route("Demo")]
public class DemoController : ControllerBase
{
    
    [HttpGet("getstring")]
    public string GetName()
    {
        return "Johan Vanegas";
    }
    
}