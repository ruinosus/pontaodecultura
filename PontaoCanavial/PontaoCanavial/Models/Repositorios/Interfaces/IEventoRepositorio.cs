using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
	public interface IEventoRepositorio
	{
        IQueryable<Evento> ConsultarTodos();
        Evento GetEvento(int id);

        void Add(Evento evento);
        void Delete(Evento evento);

        void Save();
	}
}
