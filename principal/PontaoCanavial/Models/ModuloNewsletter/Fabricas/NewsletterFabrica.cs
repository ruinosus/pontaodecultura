using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloNewsletter.Repositorios;

namespace PontaoCanavial.Models.ModuloNewsletter.Fabricas
{
    /// <summary>
    /// Classe NewsletterFabrica
    /// </summary>
    public class NewsletterFabrica
    {
        #region Atributos
        private static INewsletterRepositorio iNewsletterRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface INewsletterRepositorio.
        /// </summary>
        public static INewsletterRepositorio INewsletterInstance
        {
            get
            {
                iNewsletterRepositorioInstance = new NewsletterRepositorio();
                return iNewsletterRepositorioInstance;
            }

        }
        #endregion
    }
}