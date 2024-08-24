using Microsoft.EntityFrameworkCore;
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Maps;

namespace Mvc.Web.Model
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new MatriculaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
