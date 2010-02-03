using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Models.Repositorios.Interfaces;

namespace PontaoCanavial.Models.Repositorios
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Usuario> ConsultarTodos()
        {
            return db.Usuario;
        }

        public Usuario GetUsuario(int id)
        {
            return db.Usuario.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Usuario usuario)
        {
            db.Usuario.InsertOnSubmit(usuario);
        }

        public void Delete(Usuario usuario)
        {
            db.Usuario.DeleteOnSubmit(usuario);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

    }
}
