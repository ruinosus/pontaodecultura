using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloUsuarioPonto.Repositorios;

namespace PontaoCanavial.Models.ModuloUsuarioPonto.Fabricas
{
    /// <summary>
    /// Classe UsuarioPontoFabrica
    /// </summary>
    public class UsuarioPontoFabrica
    {
        #region Atributos
        private static IUsuarioPontoRepositorio iUsuarioPontoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IUsuarioPontoRepositorio.
        /// </summary>
        public static IUsuarioPontoRepositorio IUsuarioPontoInstance
        {
            get
            {
                iUsuarioPontoRepositorioInstance = new UsuarioPontoRepositorio();
                return iUsuarioPontoRepositorioInstance;
            }

        }
        #endregion
    }
}