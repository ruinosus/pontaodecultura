using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloImagem.Constantes;

namespace PontaoCanavial.Models.ModuloImagem.Excecoes
{
    /// <summary>
    /// Classe ImagemNaoIncluidaExcecao
    /// </summary>
    public class ImagemNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ImagemNaoIncluidaExcecao()
            : base(ImagemConstantes.IMAGEM_NAO_INCLUIDA)
        { }
    }
}