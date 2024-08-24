﻿

using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class ExcluirCursoUseCase
    {
        private readonly ICursoRepository _cursoRepository;

        public ExcluirCursoUseCase(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public void ExcluirCurso(int id) 
        {
            var curso = _cursoRepository.SelecionarPorId(id);
            if (curso != null)
            {
                _cursoRepository.Excluir(id);
            }
        }
    }
}
