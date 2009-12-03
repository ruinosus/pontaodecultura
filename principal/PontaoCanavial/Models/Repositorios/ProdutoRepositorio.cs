using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios
{
    public class ProdutoRepositorio: IProdutoRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Produto> ConsultarTodos()
        {
            return db.Produto;
        }


        public Produto GetProduto(int id)
        {
            return db.Produto.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Produto produto)
        {
            db.Produto.InsertOnSubmit(produto);
        }

        public void Delete(Produto produto)
        {
            db.Produto.DeleteOnSubmit(produto);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

        
    }
}
