using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface ICategoriaRepositoriooLD
    {
        IQueryable<Categoria> ConsultarTodos();
        Categoria GetCategoria(int id);

        void Add(Categoria categoria);
        void Delete(Categoria categoria);

        void Save();
    
    }
}
