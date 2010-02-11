using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProduto.Constantes;

namespace PontaoCanavial.Models.ModuloProduto.Excecoes
{
    /// <summary>
    /// Classe ProdutoNaoExcluidoExcecao
    /// </summary>
    public class ProdutoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProdutoNaoExcluidoExcecao()
            : base(ProdutoConstantes.PRODUTO_NAO_EXCLUIDO)
        { }
    }
}