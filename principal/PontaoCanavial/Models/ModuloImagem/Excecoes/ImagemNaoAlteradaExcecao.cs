using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloImagem.Constantes;

namespace PontaoCanavial.Models.ModuloImagem.Excecoes
{
    /// <summary>
    /// Classe ImagemNaoAlteradaExcecao
    /// </summary>
    public class ImagemNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ImagemNaoAlteradaExcecao()
            : base(ImagemConstantes.IMAGEM_NAO_ALTERADA)
        { }
    }
}