using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloImagem.Repositorios;

namespace PontaoCanavial.Models.ModuloImagem.Fabricas
{
    /// <summary>
    /// Classe ImagemFabrica
    /// </summary>
    public class ImagemFabrica
    {
        #region Atributos
        private static IImagemRepositorio iImagemRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IImagemRepositorio.
        /// </summary>
        public static IImagemRepositorio IImagemInstance
        {
            get
            {
                iImagemRepositorioInstance = new ImagemRepositorio();
                return iImagemRepositorioInstance;
            }

        }
        #endregion
    }
}