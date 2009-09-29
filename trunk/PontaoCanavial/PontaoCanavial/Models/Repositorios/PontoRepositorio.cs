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

        public IQueryable<Ponto> ConsultarTodos()
        {
            return db.Pontos;
        }

        public Ponto ConsultarPorNomeIdentificador(string nomeIdentificador)
        {
            return db.Pontos.SingleOrDefault(d => d.NomeIdentificador.Equals(nomeIdentificador));
        }

        public Ponto ConsultarPontao()
        {
            return db.Pontos.SingleOrDefault(d => d.EPontao == true);

        }

        public Ponto GetPonto(int id)
        {
            return db.Pontos.SingleOrDefault(d => d.Id == id);
        
        }

        public void Add(Ponto ponto)
        {
            db.Pontos.InsertOnSubmit(ponto);
        }

        public void Delete(Ponto ponto)
        {
            db.Banners.DeleteAllOnSubmit(ponto.Banners);
            db.Galerias.DeleteAllOnSubmit(ponto.Galerias);
            
            foreach (Galeria galeria in ponto.Galerias)
            {
                db.Imagems.DeleteAllOnSubmit(galeria.Imagems);
            }

            db.Newsletters.DeleteAllOnSubmit(ponto.Newsletters);
            db.Noticias.DeleteAllOnSubmit(ponto.Noticias);
            db.Produtos.DeleteAllOnSubmit(ponto.Produtos);
            db.UsuarioPontos.DeleteAllOnSubmit(ponto.UsuarioPontos);
            db.Pontos.DeleteOnSubmit(ponto);
        }

        public void Save()
        {
            db.SubmitChanges();
        }

        #endregion
    }
}
