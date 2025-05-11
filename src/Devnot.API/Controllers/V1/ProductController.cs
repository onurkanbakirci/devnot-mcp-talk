namespace Devnot.API.Controllers.V1;

[ApiController]
[Route("api/v{version:apiVersion}/products")]
[ApiVersion("1.0")]
public class ProductController(ApplicationDbContext context) : ControllerBase
{
    private readonly ApplicationDbContext _context = context;

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Products.ToList());
    }
}