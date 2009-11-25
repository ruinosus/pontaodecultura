using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Models.Repositorios.Interfaces;

namespace PontaoCanavial.Models.Repositorios
{
    public class NewsletterRepositorio: INewsletterRepositorio
    {
            PontaoCanavialDataContext db = new PontaoCanavialDataContext();

            #region Métodos da Interface

            public IQueryable<Newsletter> ConsultarTodos()
            {
                return db.Newsletters;
            }

            public Newsletter ConsultarPorEmail(string email)
            {
                return db.Newsletters.SingleOrDefault(d => d.Email.Equals(email));
            }

            public Newsletter GetNewsletter(int id)
            {
                return db.Newsletters.SingleOrDefault(d => d.Id == id);
            }

            public void Add(Newsletter news)
            {
                db.Newsletters.InsertOnSubmit(news);
            }

            public void Delete(Newsletter news)
            {                
                db.Newsletters.DeleteOnSubmit(news);
            }

            public void Save()
            {
                db.SubmitChanges();
            }

            #endregion


            #region INewsletterRepositorio Members


            public Newsletter ConsultarNewsletter()
            {
                throw new NotImplementedException();
            }

            #endregion
    }
}
