using Microsoft.EntityFrameworkCore;
using MVC_Victor_CRUD.Models;

namespace MVC_Victor_CRUD.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext (DbContextOptions<AlunoContext> options) : base(options){}

        public DbSet<Aluno> Aluno { get; set; }
    }
}