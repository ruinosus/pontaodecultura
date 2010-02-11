using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBanner.Constantes;

namespace PontaoCanavial.Models.ModuloBanner.Excecoes
{
    /// <summary>
    /// Classe BannerNaoIncluidoExcecao
    /// </summary>
    public class BannerNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BannerNaoIncluidoExcecao()
            : base(BannerConstantes.BANNER_NAO_INCLUIDO)
        { }
    }
}