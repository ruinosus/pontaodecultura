using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBanner.Constantes;

namespace PontaoCanavial.Models.ModuloBanner.Excecoes
{
    /// <summary>
    /// Classe BannerNaoAlteradoExcecao
    /// </summary>
    public class BannerNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BannerNaoAlteradoExcecao()
            : base(BannerConstantes.BANNER_NAO_ALTERADO)
        { }
    }
}