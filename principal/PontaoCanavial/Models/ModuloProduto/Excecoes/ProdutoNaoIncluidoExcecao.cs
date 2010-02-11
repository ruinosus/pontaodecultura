using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProduto.Constantes;

namespace PontaoCanavial.Models.ModuloProduto.Excecoes
{
    /// <summary>
    /// Classe ProdutoNaoIncluidoExcecao
    /// </summary>
    public class ProdutoNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProdutoNaoIncluidoExcecao()
            : base(ProdutoConstantes.PRODUTO_NAO_INCLUIDO)
        { }
    }
}