using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloPonto.Constantes;

namespace PontaoCanavial.Models.ModuloPonto.Excecoes
{
    /// <summary>
    /// Classe PontoNaoIncluidoExcecao
    /// </summary>
    public class PontoNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PontoNaoIncluidoExcecao()
            : base(PontoConstantes.PONTO_NAOINCLUIDO)
        { }
    }
}
