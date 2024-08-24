using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarTodosAlunosUseCase
    {
        private readonly IAlunoRepository _alunoRepository;

        public ListarTodosAlunosUseCase(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public List<Aluno> ListarAlunos() 
        {
            return _alunoRepository.SelecionarTudo();
        }
    }
}
