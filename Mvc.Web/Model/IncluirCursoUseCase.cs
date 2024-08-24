﻿
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class IncluirCursoUseCase
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IProfessorRepository _professorRepository;

        public IncluirCursoUseCase(ICursoRepository cursoRepository, IProfessorRepository professorRepository)
        {
            _cursoRepository = cursoRepository;
            _professorRepository = professorRepository; 
        }

        public Curso IncluirCurso(string nome, string descricao, DateTime dataInicio, int idProfessor) 
        {
            var professor = _professorRepository.SelecionarPorId(idProfessor);
            if (professor == null)
            {
                return null;
                // professor não cadastrado
            }

            var curso = new Curso()
            {
                Nome = nome,
                Descricao = descricao,
                DataInicio = dataInicio,
                Ativo = true,
                IdProfessor = idProfessor
            };

            _cursoRepository.Incluir(curso);

            return curso;
        }
    }
}
