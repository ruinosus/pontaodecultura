using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloEvento.Constantes;

namespace PontaoCanavial.Models.ModuloEvento.Excecoes
{
    /// <summary>
    /// Classe EventoNaoIncluidoExcecao
    /// </summary>
    public class EventoNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public EventoNaoIncluidoExcecao()
            : base(EventoConstantes.EVENTO_NAO_INCLUIDO)
        { }
    }
}