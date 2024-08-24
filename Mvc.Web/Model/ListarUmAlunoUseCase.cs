
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ListarUmAlunoUseCase
    {
        private readonly IAlunoRepository _alunoRepository;

        public ListarUmAlunoUseCase(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public Aluno ListarUmAluno(int id) 
        {
            return _alunoRepository.SelecionarPorId(id);
        }
    }
}
