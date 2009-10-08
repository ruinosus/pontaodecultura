using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface INoticiaRepositorio
    {
        IQueryable<Noticia> ConsultarTodos();
        Noticia GetNoticia(int id);

        void Add(Noticia noticia);
        void Delete(Noticia noticia);

        void Save();
    }
}
