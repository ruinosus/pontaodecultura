using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloVideo.Constantes;

namespace PontaoCanavial.Models.ModuloVideo.Excecoes
{
    /// <summary>
    /// Classe VideoNaoIncluidoExcecao
    /// </summary>
    public class VideoNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public VideoNaoIncluidoExcecao()
            : base(VideoConstantes.VIDEO_NAO_INCLUIDO)
        { }
    }
}