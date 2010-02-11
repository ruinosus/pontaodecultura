using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloNoticia.Repositorios;

namespace PontaoCanavial.Models.ModuloNoticia.Fabricas
{
    /// <summary>
    /// Classe NoticiaFabrica
    /// </summary>
    public class NoticiaFabrica
    {
        #region Atributos
        private static INoticiaRepositorio iNoticiaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface INoticiaRepositorio.
        /// </summary>
        public static INoticiaRepositorio INoticiaInstance
        {
            get
            {
                iNoticiaRepositorioInstance = new NoticiaRepositorio();
                return iNoticiaRepositorioInstance;
            }

        }
        #endregion
    }
}