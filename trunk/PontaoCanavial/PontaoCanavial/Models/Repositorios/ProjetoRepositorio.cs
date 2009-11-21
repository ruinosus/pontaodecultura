using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios
{
    public class ProjetoRepositorio: IProjetoRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Projeto> ConsultarTodos()
        {
            return db.Projetos;
        }

        public Projeto GetProjeto(int id)
        {
            return db.Projetos.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Projeto projeto)
        {
            db.Projetos.InsertOnSubmit(projeto);
        }

        public void Delete(Projeto projeto)
        {
            db.Projetos.DeleteOnSubmit(projeto);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

        #region IEventoRepositorio Members


        public Projeto ConsultarProjeto()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
