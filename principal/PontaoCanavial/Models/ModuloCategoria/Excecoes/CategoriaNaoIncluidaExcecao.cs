using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloCategoria.Constantes;

namespace PontaoCanavial.Models.ModuloCategoria.Excecoes
{
    /// <summary>
    /// Classe CategoriaNaoIncluidaExcecao
    /// </summary>
    public class CategoriaNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public CategoriaNaoIncluidaExcecao()
            : base(CategoriaConstantes.CATEGORIA_NAO_INCLUIDA)
        { }
    }
}