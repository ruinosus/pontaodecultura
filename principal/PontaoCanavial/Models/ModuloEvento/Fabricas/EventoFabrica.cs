using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloEvento.Repositorios;

namespace PontaoCanavial.Models.ModuloEvento.Fabricas
{
    /// <summary>
    /// Classe EventoFabrica
    /// </summary>
    public class EventoFabrica
    {
        #region Atributos
        private static IEventoRepositorio iEventoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IEventoRepositorio.
        /// </summary>
        public static IEventoRepositorio IEventoInstance
        {
            get
            {
                iEventoRepositorioInstance = new EventoRepositorio();
                return iEventoRepositorioInstance;
            }

        }
        #endregion
    }
}