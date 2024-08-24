
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarTodosCursosUseCase
    {
        private readonly ICursoRepository _cursoRepository;

        public ListarTodosCursosUseCase(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public List<Curso> ListarCursos() 
        {
            return _cursoRepository.SelecionarTudo();
        }
    }
}
