using Microsoft.AspNetCore.Mvc;
using Models;
using PACEserver.Contexts;

namespace PACEserver.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly AppDbContext _context;

    public AlunoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable <Aluno>> GetAllAlunos()
    {
        var alunos = _context.Alunos.ToList();
        if (alunos is null) {
            return NotFound("Alunos não encontrados");
        }
        return alunos;
    }
}
