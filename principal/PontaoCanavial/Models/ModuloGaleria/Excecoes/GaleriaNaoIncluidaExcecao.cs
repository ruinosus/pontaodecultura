using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloGaleria.Constantes;

namespace PontaoCanavial.Models.ModuloGaleria.Excecoes
{
    /// <summary>
    /// Classe GaleriaNaoIncluidaExcecao
    /// </summary>
    public class GaleriaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public GaleriaNaoIncluidaExcecao()
            : base(GaleriaConstantes.GALERIA_NAO_INCLUIDA)
        { }
    }
}