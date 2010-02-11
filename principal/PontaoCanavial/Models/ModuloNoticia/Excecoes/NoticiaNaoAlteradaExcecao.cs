using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloNoticia.Constantes;

namespace PontaoCanavial.Models.ModuloNoticia.Excecoes
{
    /// <summary>
    /// Classe NoticiaNaoAlteradaExcecao
    /// </summary>
    public class NoticiaNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public NoticiaNaoAlteradaExcecao()
            : base(NoticiaConstantes.NOTICIA_NAO_ALTERADA)
        { }
    }
}