using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProjeto.Constantes;

namespace PontaoCanavial.Models.ModuloProjeto.Excecoes
{
    /// <summary>
    /// Classe ProjetoNaoAlteradoExcecao
    /// </summary>
    public class ProjetoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProjetoNaoAlteradoExcecao()
            : base(ProjetoConstantes.PROJETO_NAO_ALTERADO)
        { }
    }
}