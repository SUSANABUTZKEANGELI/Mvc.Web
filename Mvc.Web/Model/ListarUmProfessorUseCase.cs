
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarUmProfessorUseCase
    {
        private readonly IProfessorRepository _professorRepository;

        public ListarUmProfessorUseCase(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public Professor ListarUmProfessor(int id) 
        {
            return _professorRepository.SelecionarPorId(id);
        }
    }
}
