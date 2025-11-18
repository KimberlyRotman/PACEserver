using Microsoft.AspNetCore.Mvc;
using Models;
using PACEserver.Contexts;

namespace PACEserver.Controllers;

[ApiController]
[Route("[controller]")]
public class MateriaController : ControllerBase
{
    private readonly AppDbContext _context;

    public MateriaController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Materia>> GetAllMaterias()
    {
        var materias = _context.Materias.ToList();
        if (materias is null)
        {
            return NotFound("Materias não encontrados");
        }
        return materias;
    }
}
