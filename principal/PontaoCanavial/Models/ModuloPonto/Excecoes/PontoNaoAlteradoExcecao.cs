using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloPonto.Constantes;

namespace PontaoCanavial.Models.ModuloPonto.Excecoes
{
    /// <summary>
    /// Classe PontoNaoAlteradoExcecao
    /// </summary>
    public class PontoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PontoNaoAlteradoExcecao()
            : base(PontoConstantes.PONTO_NAOALTERADO)
        { }
    }
}
