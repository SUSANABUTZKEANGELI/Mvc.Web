
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarTodosProfessoresUseCase
    {
        private readonly IProfessorRepository _professorRepository;

        public ListarTodosProfessoresUseCase(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public List<Professor> ListarProfessores() 
        {
            return _professorRepository.SelecionarTudo();
        }
    }
}
