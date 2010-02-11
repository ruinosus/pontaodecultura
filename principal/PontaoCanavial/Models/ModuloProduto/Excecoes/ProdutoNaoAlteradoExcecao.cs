using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloProduto.Constantes;

namespace PontaoCanavial.Models.ModuloProduto.Excecoes
{
    /// <summary>
    /// Classe ProdutoNaoAlteradoExcecao
    /// </summary>
    public class ProdutoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ProdutoNaoAlteradoExcecao()
            : base(ProdutoConstantes.PRODUTO_NAO_ALTERADO)
        { }
    }
}