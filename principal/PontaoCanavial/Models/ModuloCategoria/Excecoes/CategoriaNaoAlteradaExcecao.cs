using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloCategoria.Constantes;

namespace PontaoCanavial.Models.ModuloCategoria.Excecoes
{
    /// <summary>
    /// Classe CategoriaNaoAlteradaExcecao
    /// </summary>
    public class CategoriaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public CategoriaNaoAlteradaExcecao()
            : base(CategoriaConstantes.CATEGORIA_NAO_ALTERADA)
        { }
    }
}