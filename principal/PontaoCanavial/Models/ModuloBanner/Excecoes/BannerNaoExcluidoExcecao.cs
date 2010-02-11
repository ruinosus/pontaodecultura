using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBanner.Constantes;

namespace PontaoCanavial.Models.ModuloBanner.Excecoes
{
    /// <summary>
    /// Classe BannerNaoExcluidoExcecao
    /// </summary>
    public class BannerNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BannerNaoExcluidoExcecao()
            : base(BannerConstantes.BANNER_NAO_EXCLUIDO)
        { }
    }
}