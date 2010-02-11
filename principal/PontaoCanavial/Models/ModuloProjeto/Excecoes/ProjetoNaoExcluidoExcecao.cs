using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProjeto.Constantes;

namespace PontaoCanavial.Models.ModuloProjeto.Excecoes
{
    /// <summary>
    /// Classe ProjetoNaoExcluidoExcecao
    /// </summary>
    public class ProjetoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProjetoNaoExcluidoExcecao()
            : base(ProjetoConstantes.PROJETO_NAO_EXCLUIDO)
        { }
    }
}