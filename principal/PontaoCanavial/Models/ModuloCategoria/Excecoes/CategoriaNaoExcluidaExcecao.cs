using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloCategoria.Constantes;

namespace PontaoCanavial.Models.ModuloCategoria.Excecoes
{
    /// <summary>
    /// Classe CategoriaNaoExcluidaExcecao
    /// </summary>
    public class CategoriaNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public CategoriaNaoExcluidaExcecao()
            : base(CategoriaConstantes.CATEGORIA_NAO_EXCLUIDA)
        { }
    }
}