using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloUsuario.Constantes;

namespace PontaoCanavial.Models.ModuloUsuario.Excecoes
{
    /// <summary>
    /// Classe UsuarioNaoIncluidoExcecao
    /// </summary>
    public class UsuarioNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioNaoIncluidoExcecao()
            : base(UsuarioConstantes.USUARIO_NAO_INCLUIDO)
        { }
    }
}