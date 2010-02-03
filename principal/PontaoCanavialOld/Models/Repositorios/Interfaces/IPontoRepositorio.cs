using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Controllers;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IPontoRepositorio
    {
        IQueryable<Ponto> ConsultarTodos(bool consultarApenasPontinhos);
        Ponto ConsultarPorNomeIdentificador(string nomeIdentificador);
        Ponto ConsultarPontao();
        Ponto GetPonto(int id);
        PontoFormViewModel Buscar(PontoFormViewModel pfvm, string valor,int id);

        void Add(Ponto ponto);
        void Delete(Ponto ponto);

        void Save();
    }
}
