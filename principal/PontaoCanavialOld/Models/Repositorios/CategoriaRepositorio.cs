using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios
{
    public class CategoriaRepositorio: ICategoriaRepositoriooLD
    {
         PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

         public IQueryable<Categoria> ConsultarTodos()
        {
            return db.Categoria;
        }

        public Categoria GetCategoria(int id)
        {
            return db.Categoria.SingleOrDefault(d => d.Id == id);
        
        }

        public void Add(Categoria categoria)
        {
            db.Categoria.InsertOnSubmit(categoria);
        }

        public void Delete(Categoria categoria)
        {
            db.Categoria.DeleteOnSubmit(categoria);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

    }
}
