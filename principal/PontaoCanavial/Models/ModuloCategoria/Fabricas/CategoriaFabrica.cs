using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloCategoria.Repositorios;

namespace PontaoCanavial.Models.ModuloCategoria.Fabricas
{
    /// <summary>
    /// Classe CategoriaFabrica
    /// </summary>
    public class CategoriaFabrica
    {
        #region Atributos
        private static ICategoriaRepositorio iCategoriaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ICategoriaRepositorio.
        /// </summary>
        public static ICategoriaRepositorio ICategoriaInstance
        {
            get
            {
                iCategoriaRepositorioInstance = new CategoriaRepositorio();
                return iCategoriaRepositorioInstance;
            }

        }
        #endregion
    }
}