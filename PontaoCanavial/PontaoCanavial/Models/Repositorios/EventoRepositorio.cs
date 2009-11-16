using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Models.Repositorios.Interfaces;

namespace PontaoCanavial.Models.Repositorios
{
    public class EventoRepositorio : IEventoRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Evento> ConsultarTodos()
        {
            return db.Eventos;
        }

        public Evento GetEvento(int id)
        {
            return db.Eventos.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Evento evento)
        {
            db.Eventos.InsertOnSubmit(evento);
        }

        public void Delete(Evento evento)
        {
            db.Eventos.DeleteOnSubmit(evento);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

        #region IEventoRepositorio Members


        #endregion
    }
}
