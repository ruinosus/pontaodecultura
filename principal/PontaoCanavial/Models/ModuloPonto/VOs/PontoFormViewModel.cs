using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PontaoCanavial.Models.ModuloPonto.VOs
{
    public class PontoFormViewModel
    {
        #region Propriedades

        public Ponto Ponto { get; private set; }
        public List<Ponto> Pontinhos { get; private set; }
        public Noticia NoticiaDetalhe { get; set; }
        public Projeto ProjetoDetalhe { get; set; }
        public Galeria GaleriaDetalhe { get; set; }
        public Produto ProdutoDetalhe { get; set; }
        public Evento EventoDetalhe { get; set; }
        public List<Noticia> NoticiasPrincipais { get; set; }
        public List<Galeria> GaleriasPrincipais { get; set; }
        public List<Noticia> NoticiasBusca { get; set; }
        public List<Galeria> GaleriasBusca { get; set; }
        public List<Evento> EventosBusca { get; set; }
        public List<Projeto> ProjetosBusca { get; set; }
        public List<SelectListItem> PontosBusca { get; set; }

        #endregion

        #region Construtores

        public PontoFormViewModel(Ponto ponto, List<Ponto> pontinhos)
        {
            PontosBusca = new List<SelectListItem>();
            foreach (Ponto p in pontinhos)
            {
                PontosBusca.Add(new SelectListItem
                {
                    Text = p.Nome,
                    Value = p.ID.ToString()
                });
            }
            Ponto = ponto;
            Pontinhos = pontinhos;
        }

        #endregion
    }
}
