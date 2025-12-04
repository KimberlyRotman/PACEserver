using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        var tarefas = _context.Tarefas.AsNoTracking().ToList();
        if (tarefas is null)
        {
            return NotFound("Tarefas não encontradas");
        }
        return Ok(tarefas);
    }

    [HttpGet("{id:Guid}")]
    public ActionResult<Tarefa> GetTarefaById(Guid id)
    {
        var tarefa = _context.Tarefas
            .Include(t => t.Materia)
            .Include(t => t.Plataforma)
            .Include(t => t.Materia.Professor)
            .FirstOrDefault(t => t.Id == id);

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
            return NotFound("Tarefa não encontrada");

        return Ok(tarefa);
    }

    [HttpPost]
    public ActionResult Post(Tarefa tarefa)
    {
        int ultimoCodigo = _context.Tarefas
            .OrderByDescending(t => t.Codigo)
            .Select(t => t.Codigo)
            .FirstOrDefault();

        tarefa.Codigo = ultimoCodigo == 0 ? 5000 : ultimoCodigo + 1;
        tarefa.Id = Guid.NewGuid();
        tarefa.DataCriacao = DateTime.UtcNow;

        _context.Tarefas.Add(tarefa);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetTarefaById), new { id = tarefa.Id }, tarefa);
    }


    [HttpPut]
    public ActionResult Put(Tarefa tarefa)
    {
        if (tarefa is null)
        {
            return BadRequest("Dados inválidos");
        }

        var tarefaExistente = _context.Tarefas.Find(tarefa.Id);
        if (tarefaExistente is null)
        {
            return NotFound("Tarefa não encontrada");
        }
        _context.Tarefas.Update(tarefa);
        _context.SaveChanges();
        return Ok(tarefa);
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult Delete(Guid id)
    {
        var tarefa = _context.Tarefas.Find(id);
        if (tarefa is null)
        {
            return NotFound("Tarefa não encontrada");
        }
        _context.Tarefas.Remove(tarefa);
        _context.SaveChanges();
        return Ok();
    }
}
