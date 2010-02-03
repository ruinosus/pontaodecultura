using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Models.Repositorios.Interfaces;

namespace PontaoCanavial.Models.Repositorios
{
    public class GaleriaRepositorio: IGaleriaRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Galeria> ConsultarTodos()
        {
            return db.Galeria;
        }

        public Galeria GetGaleria(int id)
        {
            return db.Galeria.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Galeria galeria)
        {
            db.Galeria.InsertOnSubmit(galeria);
        }

        public void Delete(Galeria galeria)
        {
            //db.Galerias.DeleteAllOnSubmit(galeria.Imagems);

            foreach (Imagem imagem in galeria.Imagem)
            {
                db.Imagem.DeleteAllOnSubmit(galeria.Imagem);
            }

            db.Galeria.DeleteOnSubmit(galeria);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

    }
}
