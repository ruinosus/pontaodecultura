using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloPonto.Constantes;

namespace PontaoCanavial.Models.ModuloPonto.Excecoes
{
    /// <summary>
    /// Classe PontoNaoExcluidoExcecao
    /// </summary>
    public class PontoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PontoNaoExcluidoExcecao()
            : base(PontoConstantes.PONTO_NAOEXCLUIDO)
        { }
    }
}
