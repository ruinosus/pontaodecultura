using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        IQueryable<Usuario> ConsultarTodos();
        Usuario ConsultarUsuario();
        Usuario GetUsuario(int id);

        void Add(Usuario usuario);
        void Delete(Usuario usuario);

        void Save();
    }
}
