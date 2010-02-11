using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloUsuarioPonto.Repositorios
{
    public interface IUsuarioPontoRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir um usuarioPonto no sistema.
        /// </summary>
        /// <param name="usuarioPonto">Objeto do tipo usuarioPonto a ser incluido.</param>
        void Incluir(UsuarioPonto usuarioPonto);

        /// <summary>
        /// M�todo respons�vel por excluir um usuarioPonto do sistema.
        /// </summary>
        /// <param name="usuarioPonto">Objeto do tipo usuarioPonto a ser excluido.</param>
        void Excluir(UsuarioPonto usuarioPonto);

        /// <summary>
        /// M�todo repons�vel por alterar um usuarioPonto do sistema.
        /// </summary>
        /// <param name="usuarioPonto">Objeto do tipo usuarioPonto a ser alterado.</param>
        void Alterar(UsuarioPonto usuarioPonto);

        /// <summary>
        /// M�todo respons�vel por consultar usuarioPontos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="usuarioPonto">Objeto do tipo usuarioPonto que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os usuarioPontos cadastrados.</returns>
        List<UsuarioPonto> Consultar(UsuarioPonto usuarioPonto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os usuarioPontos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os usuarioPontos cadastrados.</returns>
        List<UsuarioPonto> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}