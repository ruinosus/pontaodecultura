using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloUsuario.Constantes;

namespace PontaoCanavial.Models.ModuloUsuario.Excecoes
{
    /// <summary>
    /// Classe UsuarioNaoAlteradoExcecao
    /// </summary>
    public class UsuarioNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioNaoAlteradoExcecao()
            : base(UsuarioConstantes.USUARIO_NAO_ALTERADO)
        { }
    }
}