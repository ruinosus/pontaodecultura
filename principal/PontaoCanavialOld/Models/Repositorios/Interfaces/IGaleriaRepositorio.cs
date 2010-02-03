using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IGaleriaRepositorio
    {
        IQueryable<Galeria> ConsultarTodos();
        Galeria GetGaleria(int id);

        void Add(Galeria galeria);
        void Delete(Galeria galeria);

        void Save();
    }
}
