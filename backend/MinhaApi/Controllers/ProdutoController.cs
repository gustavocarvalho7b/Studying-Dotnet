using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Controller funcionando");
    }
}