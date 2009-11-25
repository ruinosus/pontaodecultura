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
            return db.Galerias;
        }

        public Galeria GetGaleria(int id)
        {
            return db.Galerias.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Galeria galeria)
        {
            db.Galerias.InsertOnSubmit(galeria);
        }

        public void Delete(Galeria galeria)
        {
            //db.Galerias.DeleteAllOnSubmit(galeria.Imagems);

            foreach (Imagem imagem in galeria.Imagems)
            {
                db.Imagems.DeleteAllOnSubmit(galeria.Imagems);
            }

            db.Galerias.DeleteOnSubmit(galeria);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion

        #region IGaleriaRepositorio Members


        public Galeria ConsultarGaleria()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IGaleriaRepositorio Members

        IQueryable<Galeria> IGaleriaRepositorio.ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        Galeria IGaleriaRepositorio.ConsultarGaleria()
        {
            throw new NotImplementedException();
        }

        Galeria IGaleriaRepositorio.GetGaleria(int id)
        {
            throw new NotImplementedException();
        }

        void IGaleriaRepositorio.Add(Galeria galeria)
        {
            throw new NotImplementedException();
        }

        void IGaleriaRepositorio.Delete(Galeria galeria)
        {
            throw new NotImplementedException();
        }

        void IGaleriaRepositorio.Save()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
