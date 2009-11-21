using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IProjetoRepositorio
    {
        IQueryable<Projeto> ConsultarTodos();
        Projeto GetProjeto(int id);

        void Add(Projeto projeto);
        void Delete(Projeto projeto);

        void Save();
    }
}
