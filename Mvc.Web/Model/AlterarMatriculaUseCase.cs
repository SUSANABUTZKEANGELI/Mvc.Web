using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Entities.Enums;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class AlterarMatriculaUseCase
    {
        private readonly IMatriculaRepository _matriculaRepository;

        public AlterarMatriculaUseCase(IMatriculaRepository matriculaRepository)
        {
            _matriculaRepository = matriculaRepository;
        }

        public Matricula AlterarMatricula(int id, StatusMatricula statusMatricula)
        {
            var matricula = _matriculaRepository.SelecionarPorId(id);
            if (matricula == null)
            {
                return null;
                // Matricula não existente
            }

            matricula.StatusMatricula = statusMatricula;

            _matriculaRepository.Alterar(matricula);

            return matricula;
        }
    }
}
