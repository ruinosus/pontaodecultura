using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;

namespace PontaoCanavial.Models.Repositorios
{
    public class PontoRepositorio : IPontoRepositorio
    {
        PontaoCanavialDataContext db = new PontaoCanavialDataContext();

        #region Métodos da Interface

        public IQueryable<Ponto> ConsultarTodos(bool consultarApenasPontinhos)
        {
            if (!consultarApenasPontinhos)
                return db.Ponto;

            return from p in db.Ponto
                   where p.EPontao == false || p.EPontao==null
                   select p;
        }

        public Ponto ConsultarPorNomeIdentificador(string nomeIdentificador)
        {
            return db.Ponto.SingleOrDefault(d => d.NomeIdentificador.Equals(nomeIdentificador));
        }

        public Ponto ConsultarPontao()
        {
            return db.Ponto.SingleOrDefault(d => d.EPontao == true);

        }

        public Ponto GetPonto(int id)
        {
            return db.Ponto.SingleOrDefault(d => d.Id == id);

        }

        public void Add(Ponto ponto)
        {
            db.Ponto.InsertOnSubmit(ponto);
        }

        public void Delete(Ponto ponto)
        {
            db.Banner.DeleteAllOnSubmit(ponto.Banner);
            db.Galeria.DeleteAllOnSubmit(ponto.Galeria);

            foreach (Galeria galeria in ponto.Galeria)
            {
                db.Imagem.DeleteAllOnSubmit(galeria.Imagem);
            }

            db.Newsletter.DeleteAllOnSubmit(ponto.Newsletter);
            db.Noticia.DeleteAllOnSubmit(ponto.Noticia);
            db.Produto.DeleteAllOnSubmit(ponto.Produto);
            db.UsuarioPonto.DeleteAllOnSubmit(ponto.UsuarioPonto);
            db.Ponto.DeleteOnSubmit(ponto);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}
