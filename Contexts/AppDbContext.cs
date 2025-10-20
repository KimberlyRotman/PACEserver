using Microsoft.EntityFrameworkCore;
using Models;

namespace PACEserver.Contexts;

public class AppDbContext
    : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Equipe> Equipes { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<Plataforma> Plataformas { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }
    public DbSet<TarefaAluno> TarefasAlunos { get; set; }

}
