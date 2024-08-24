using Mvc.Web.Model.Entities;

namespace Mvc.Web.Model.Interfaces
{
    public interface IMatriculaRepository : IBaseRepository<Matricula>
    {
        Matricula SelecionarPorIdAlunoCurso(int idAluno, int idCurso);
        List<Matricula> SelecionarTudoCompleto();
    }
}
