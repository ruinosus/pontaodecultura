using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios
{
    public class UsuarioPontoRepositorio: IUsuarioPontoRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<UsuarioPonto> ConsultarTodos()
        {
            return db.UsuarioPontos;
        }

        public UsuarioPonto GetUsuarioPonto(int id)
        {
            return db.UsuarioPontos.SingleOrDefault(d => d.Id == id);
        }

        public void Add(UsuarioPonto usuPonto)
        {
            db.UsuarioPontos.InsertOnSubmit(usuPonto);
        }

        public void Delete(UsuarioPonto usuPonto)
        {
            db.UsuarioPontos.DeleteOnSubmit(usuPonto);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}
