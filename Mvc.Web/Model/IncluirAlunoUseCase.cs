
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class IncluirAlunoUseCase
    {
        private readonly IAlunoRepository _alunoRepository;

        public IncluirAlunoUseCase(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public Aluno IncluirAluno(string nome, string endereco, string email) 
        {
            var aluno = new Aluno()
            {
                Name = nome,
                Email = email,
                Endereco = endereco,
                Ativo = true
            };

            _alunoRepository.Incluir(aluno);

            return aluno;
        }
    }
}
