using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model.Dados
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
