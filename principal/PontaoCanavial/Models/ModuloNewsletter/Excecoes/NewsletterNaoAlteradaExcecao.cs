using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloNewsletter.Constantes;

namespace PontaoCanavial.Models.ModuloNewsletter.Excecoes
{
    /// <summary>
    /// Classe NewsletterNaoAlteradaExcecao
    /// </summary>
    public class NewsletterNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public NewsletterNaoAlteradaExcecao()
            : base(NewsletterConstantes.NEWSLETTER_NAO_ALTERADA)
        { }
    }
}