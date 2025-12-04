using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PACEserver.Contexts;
using Models;

namespace PACEserver.Controllers;

[ApiController]
[Route("tarefasAluno")]
public class TarefaAlunoController : ControllerBase
{
    private readonly AppDbContext _context;

    public TarefaAlunoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{alunoId:Guid}")]
    public ActionResult GetTarefasDoAluno(Guid alunoId)
    {
        var tarefas = _context.TarefasAlunos
            .Where(t => t.AlunoId == alunoId)
            .Include(t => t.Tarefa)
                .ThenInclude(m => m.Materia)
            .AsNoTracking()
            .ToList();

        return Ok(tarefas);
    }

    [HttpPut("status")]
    public ActionResult AlterarStatus([FromBody] UpdateKanbamDTO request)
    {
        var tarefa = _context.TarefasAlunos.Find(request.TarefaAlunoId);

        if (tarefa == null)
            return NotFound("TarefaAluno não existe");

        tarefa.Kambam = request.Kanbam; // enum agora
        _context.SaveChanges();

        return Ok("Status atualizado");
    }

}