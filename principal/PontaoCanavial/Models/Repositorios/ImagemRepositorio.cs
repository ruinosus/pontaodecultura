using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios
{
    public class ImagemRepositorio: IImagemRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        IQueryable<Imagem> IImagemRepositorio.ConsultarTodos()
        {
            return db.Imagem;
        }

        Imagem IImagemRepositorio.GetImagem(int id)
        {
            return db.Imagem.SingleOrDefault(d => d.Id == id);

        }

         void IImagemRepositorio.Add(Imagem imagem)
        {
            db.Imagem.InsertOnSubmit(imagem);
        }

        void IImagemRepositorio.Delete(Imagem imagem)
        {
            db.Imagem.DeleteOnSubmit(imagem);
        }

        void IImagemRepositorio.Save()
        {
            db.SubmitChanges();
        }

        #endregion


        #region IImagemRepositorio Members


        public Imagem ConsultarImagem()
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
