using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        IQueryable<Produto> ConsultarTodos();
        Produto GetProduto(int id);

        void Add(Produto produto);
        void Delete(Produto produto);

        void Save();
    }
}
