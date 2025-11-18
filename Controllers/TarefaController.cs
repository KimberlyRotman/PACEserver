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

}
