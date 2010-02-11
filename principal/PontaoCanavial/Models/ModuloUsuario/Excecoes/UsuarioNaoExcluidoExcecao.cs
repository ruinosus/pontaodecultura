using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloUsuario.Constantes;

namespace PontaoCanavial.Models.ModuloUsuario.Excecoes
{
    /// <summary>
    /// Classe UsuarioNaoExcluidoExcecao
    /// </summary>
    public class UsuarioNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioNaoExcluidoExcecao()
            : base(UsuarioConstantes.USUARIO_NAO_EXCLUIDO)
        { }
    }
}