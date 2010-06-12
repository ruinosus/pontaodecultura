using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloNewsletter.Fabricas;
using PontaoCanavial.Models.ModuloNewsletter.Repositorios;

namespace PontaoCanavial.Models.ModuloNewsletter.Processos
{
    public class NewsletterProcesso :Singleton<NewsletterProcesso>, INewsletterProcesso
    {
        #region Atributos
        private INewsletterRepositorio newsletterRepositorio = null;
        #endregion

        #region Construtor
        public NewsletterProcesso()
        {
            newsletterRepositorio = NewsletterFabrica.INewsletterInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Newsletter newsletter)
        {
            try
            {
                this.newsletterRepositorio.Incluir(newsletter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Newsletter newsletter)
        {
            try
            {
                this.newsletterRepositorio.Excluir(newsletter);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.newsletterRepositorio.Excluir(newsletter);
        }

        public void Alterar(Newsletter newsletter)
        {
            this.newsletterRepositorio.Alterar(newsletter);
        }

        public List<Newsletter> Consultar(Newsletter newsletter, TipoPesquisa tipoPesquisa)
        {
            List<Newsletter> newsletterList = this.newsletterRepositorio.Consultar(newsletter, tipoPesquisa);

            return newsletterList;
        }

        public List<Newsletter> Consultar()
        {
            List<Newsletter> newsletterList = newsletterRepositorio.Consultar();

            return newsletterList;
        }

        public void Confirmar()
        {
            newsletterRepositorio.Confirmar();
        }

        #endregion
    }
       
}