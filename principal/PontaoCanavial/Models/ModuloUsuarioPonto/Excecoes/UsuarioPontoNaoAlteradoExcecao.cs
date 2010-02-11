using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloUsuarioPonto.Constantes;

namespace PontaoCanavial.Models.ModuloUsuarioPonto.Excecoes
{
    /// <summary>
    /// Classe UsuarioPontoNaoAlteradoExcecao
    /// </summary>
    public class UsuarioPontoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioPontoNaoAlteradoExcecao()
            : base(UsuarioPontoConstantes.USUARIO_PONTO_NAO_ALTERADO)
        { }
    }
}