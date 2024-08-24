
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarUmCursoUseCase
    {
        private readonly ICursoRepository _cursoRepository;

        public ListarUmCursoUseCase(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public Curso ListarUmCurso(int id) 
        {
            return _cursoRepository.SelecionarPorId(id);
        }
    }
}
