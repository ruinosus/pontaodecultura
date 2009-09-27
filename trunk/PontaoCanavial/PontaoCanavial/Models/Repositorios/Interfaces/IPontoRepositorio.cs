using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IPontoRepositorio
    {
        IQueryable<Ponto> ConsultarTodos();
        Ponto ConsultarPorNomeIdentificador(string nomeIdentificador);
        Ponto ConsultarPontao();
        Ponto GetPonto(int id);

        void Add(Ponto ponto);
        void Delete(Ponto ponto);

        void Save();
    }
}
