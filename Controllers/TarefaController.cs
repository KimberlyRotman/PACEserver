using Microsoft.AspNetCore.Mvc;
using Models;
using PACEserver.Contexts;

namespace PACEserver.Controllers;

[ApiController]
[Route("[controller]")]
public class TarefaController : ControllerBase
{
    private readonly AppDbContext _context;

    public TarefaController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Tarefa>> GetAllTarefas()
    {
        var tarefas = _context.Tarefas.ToList();
        if (tarefas is null)
        {
            return NotFound("Tarefas não encontradas");
        }
        return Ok(tarefas);
    }

    [HttpGet("{id:Guid}")]
    public ActionResult<Tarefa> GetTarefaById(Guid id)
    {
        var tarefa = _context.Tarefas.Find(id);
        if (tarefa is null)
        {
            return NotFound("Tarefa não encontrada");
        }
        return Ok(tarefa);
    }

    [HttpGet("{codigo:int}")]
    public ActionResult<Tarefa> GetTarefaByCodigo(int codigo)
    {
        var tarefa = _context.Tarefas
            .FirstOrDefault(a => a.Codigo == codigo);

        if (tarefa is null)
            return NotFound("Aluno não encontrado");

        return Ok(tarefa);
    }
}
