using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using PACEserver.Contexts;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlataformaController : ControllerBase
{
    private readonly AppDbContext _context;

    public PlataformaController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/plataforma
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Plataforma>>> GetAll()
    {
        var plataformas = await _context.Plataformas.ToListAsync();
        return Ok(plataformas);
    }
}
