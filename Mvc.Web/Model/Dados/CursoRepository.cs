﻿using Microsoft.EntityFrameworkCore;
using Mvc.Web.Model.Entities;
using Mvc.Web.Model.Interfaces;

namespace Mvc.Web.Model.Dados
{
    public class CursoRepository : BaseRepository<Curso>, ICursoRepository
    {
        public CursoRepository(Contexto contexto) : base(contexto)
        {
        }

        public Task<Curso> SelecionarComMatriculas(int id)
        {
            return _contexto.Set<Curso>()
                .Include(c => c.Matriculas) // Carrega as matrículas associadas               .FirstOrDefaultAsync(c => c.Id == id);
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
