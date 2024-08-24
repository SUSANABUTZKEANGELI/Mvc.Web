using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mvc.Web.Model.Entities;

namespace Mvc.Web.Model.Maps
{
    public class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Curso)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.IdCurso);

            builder.HasOne(x => x.Aluno)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.IdAluno);

            builder.Property(x => x.StatusMatricula)
                .HasColumnType("nvarchar(10)")
                .HasConversion<string>();
        }
    }
}
