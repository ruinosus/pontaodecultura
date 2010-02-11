using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloVideo.Constantes;

namespace PontaoCanavial.Models.ModuloVideo.Excecoes
{
    /// <summary>
    /// Classe VideoNaoExcluidoExcecao
    /// </summary>
    public class VideoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public VideoNaoExcluidoExcecao()
            : base(VideoConstantes.VIDEO_NAO_EXCLUIDO)
        { }
    }
}