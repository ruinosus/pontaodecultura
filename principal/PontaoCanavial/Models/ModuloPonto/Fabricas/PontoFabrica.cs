using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloPonto.Repositorios;

namespace PontaoCanavial.Models.ModuloPonto.Fabricas
{
    /// <summary>
    /// Classe PontoFabrica
    /// </summary>
    public class PontoFabrica
    {
        #region Atributos
        private static IPontoRepositorio iPontoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IPontoRepositorio.
        /// </summary>
        public static IPontoRepositorio IPontoInstance
        {
            get
            {
                iPontoRepositorioInstance = new PontoRepositorio();
                return iPontoRepositorioInstance;
            }

        }
        #endregion
    }
}