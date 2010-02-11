using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProjeto.Repositorios;

namespace PontaoCanavial.Models.ModuloProjeto.Fabricas
{
    /// <summary>
    /// Classe ProjetoFabrica
    /// </summary>
    public class ProjetoFabrica
    {
        #region Atributos
        private static IProjetoRepositorio iProjetoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IProjetoRepositorio.
        /// </summary>
        public static IProjetoRepositorio IProjetoInstance
        {
            get
            {
                iProjetoRepositorioInstance = new ProjetoRepositorio();
                return iProjetoRepositorioInstance;
            }

        }
        #endregion
    }
}