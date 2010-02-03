using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface INewsletterRepositorio
    {
        IQueryable<Newsletter> ConsultarTodos();
        Newsletter ConsultarPorEmail(string email);
        Newsletter GetNewsletter(int id);

        void Add(Newsletter newsletter);
        void Delete(Newsletter newsletter);

        void Save();
    }
}
