using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model.Dados
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
         public AlunoRepository(Contexto contexto) : base(contexto) 
        { 
        }
    }
}
