using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IUsuarioPontoRepositorio
    {
        IQueryable<UsuarioPonto> ConsultarTodos();
        UsuarioPonto GetUsuarioPonto(int id);

        void Add(UsuarioPonto usuPonto);
        void Delete(UsuarioPonto usuPonto);

        void Save();
    }
}
