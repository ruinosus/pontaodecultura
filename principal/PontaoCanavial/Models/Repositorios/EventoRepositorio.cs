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
            return db.Evento;
        }

        public Evento GetEvento(int id)
        {
            return db.Evento.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Evento evento)
        {
            db.Evento.InsertOnSubmit(evento);
        }

        public void Delete(Evento evento)
        {
            db.Evento.DeleteOnSubmit(evento);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

    }
}
