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
                return db.Newsletter;
            }

            public Newsletter ConsultarPorEmail(string email)
            {
                return db.Newsletter.SingleOrDefault(d => d.Email.Equals(email));
            }

            public Newsletter GetNewsletter(int id)
            {
                return db.Newsletter.SingleOrDefault(d => d.Id == id);
            }

            public void Add(Newsletter news)
            {
                db.Newsletter.InsertOnSubmit(news);
            }

            public void Delete(Newsletter news)
            {                
                db.Newsletter.DeleteOnSubmit(news);
            }

            public void Save()
            {
                db.SubmitChanges();
            }

            #endregion
    }
}
