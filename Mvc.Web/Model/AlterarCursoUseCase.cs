﻿
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class AlterarCursoUseCase
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IProfessorRepository _professorRepository;


        public AlterarCursoUseCase(ICursoRepository cursoRepository, IProfessorRepository professorRepository)
        {
            _cursoRepository = cursoRepository;
            _professorRepository = professorRepository;
        }

        public Curso AlterarCurso(int id, string nome, string descricao, DateTime dataInicio, bool ativo, int idProfessor) 
        {
            var curso = _cursoRepository.SelecionarPorId(id);
            if (curso == null)
            {
                return null;
                // curso não existente
            }

            var professor = _professorRepository.SelecionarPorId(idProfessor);
            if (professor == null)
            {
                return null;
                // professor não cadastrado
            }

            curso.Nome = nome;
            curso.Descricao = descricao;
            curso.DataInicio = dataInicio;
            curso.Ativo = ativo;
            curso.IdProfessor = idProfessor;

            _cursoRepository.Alterar(curso);

            return curso;
        }
    }
}
