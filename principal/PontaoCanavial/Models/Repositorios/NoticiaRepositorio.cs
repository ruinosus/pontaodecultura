using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Models.Repositorios.Interfaces;

namespace PontaoCanavial.Models.Repositorios
{
    public class NoticiaRepositorio: INoticiaRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Noticia> ConsultarTodos()
        {
            return db.Noticia;
        }

        public Noticia GetNoticia(int id)
        {
            return db.Noticia.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Noticia noticia)
        {
            db.Noticia.InsertOnSubmit(noticia);
        }

        public void Delete(Noticia noticia)
        {
            db.Noticia.DeleteOnSubmit(noticia);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

        #region IEventoRepositorio Members


        public Noticia ConsultarNoticia()
        {
            throw new NotImplementedException();
        }

        #endregion

        
    }
}
