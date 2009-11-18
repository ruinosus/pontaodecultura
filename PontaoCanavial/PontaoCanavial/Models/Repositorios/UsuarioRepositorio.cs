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
            return db.Usuarios;
        }

        public Usuario GetUsuario(int id)
        {
            return db.Usuarios.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Usuario usuario)
        {
            db.Usuarios.InsertOnSubmit(usuario);
        }

        public void Delete(Usuario usuario)
        {
            db.Usuarios.DeleteOnSubmit(usuario);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

        #region IUsuarioRepositorio Members


        public Usuario ConsultarUsuario()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IUsuarioRepositorio Members

        IQueryable<Usuario> IUsuarioRepositorio.ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioRepositorio.ConsultarUsuario()
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioRepositorio.GetUsuario(int id)
        {
            throw new NotImplementedException();
        }

        void IUsuarioRepositorio.Add(Usuario usuario)
        {
            db.Usuarios.InsertOnSubmit(usuario);
        }

        void IUsuarioRepositorio.Delete(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        void IUsuarioRepositorio.Save()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}
