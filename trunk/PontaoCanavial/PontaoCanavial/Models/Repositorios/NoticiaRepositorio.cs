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
            return db.Noticias;
        }

        public Noticia GetNoticia (int id)
        {
            return db.Noticias.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Noticia noticia)
        {
            db.Noticias.InsertOnSubmit(noticia);
        }

        public void Delete(Noticia noticia)
        {
            db.Noticias.DeleteOnSubmit(noticia);
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
