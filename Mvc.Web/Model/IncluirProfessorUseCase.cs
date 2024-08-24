﻿
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model
{
    public class IncluirProfessorUseCase
    {
        private readonly IProfessorRepository _professorRepository;

        public IncluirProfessorUseCase(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public Professor IncluirProfessor(string nome, string email) 
        {
            var professor = new Professor()
            {
                Nome = nome,
                Email = email
            };

            _professorRepository.Incluir(professor);

            return professor;
        }
    }
}
