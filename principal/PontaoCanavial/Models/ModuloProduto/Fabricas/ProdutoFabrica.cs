using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProduto.Repositorios;

namespace PontaoCanavial.Models.ModuloProduto.Fabricas
{
    /// <summary>
    /// Classe ProdutoFabrica
    /// </summary>
    public class ProdutoFabrica
    {
        #region Atributos
        private static IProdutoRepositorio iProdutoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IProdutoRepositorio.
        /// </summary>
        public static IProdutoRepositorio IProdutoInstance
        {
            get
            {
                iProdutoRepositorioInstance = new ProdutoRepositorio();
                return iProdutoRepositorioInstance;
            }

        }
        #endregion
    }
}