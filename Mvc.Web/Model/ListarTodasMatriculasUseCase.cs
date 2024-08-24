
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarTodasMatriculasUseCase
    {
        private readonly IMatriculaRepository _matriculaRepository;

        public ListarTodasMatriculasUseCase(IMatriculaRepository matriculaRepository)
        {
            _matriculaRepository = matriculaRepository;
        }

        public List<Matricula> ListarMatriculas() 
        {
            return _matriculaRepository.SelecionarTudo();
        }
    }
}
