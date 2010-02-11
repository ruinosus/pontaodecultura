using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBanner.Repositorios;

namespace PontaoCanavial.Models.ModuloBanner.Fabricas
{
    /// <summary>
    /// Classe BannerFabrica
    /// </summary>
    public class BannerFabrica
    {
        #region Atributos
        private static IBannerRepositorio iBannerRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IBannerRepositorio.
        /// </summary>
        public static IBannerRepositorio IBannerInstance
        {
            get
            {
                iBannerRepositorioInstance = new BannerRepositorio();
                return iBannerRepositorioInstance;
            }

        }
        #endregion
    }
}