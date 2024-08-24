using Mvc.Web.Model.Entities;

namespace Mvc.Web.Model.Interfaces
{
    public interface ICursoRepository : IBaseRepository<Curso>
    {
        Task<Curso> SelecionarComMatriculas(int id);
    }
}
