using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloNewsletter.Repositorios
{
    public interface INewsletterRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma newsletter no sistema.
        /// </summary>
        /// <param name="newsletter">Objeto do tipo newsletter a ser incluido.</param>
        void Incluir(Newsletter newsletter);

        /// <summary>
        /// M�todo respons�vel por excluir uma newsletter do sistema.
        /// </summary>
        /// <param name="newsletter">Objeto do tipo newsletter a ser excluido.</param>
        void Excluir(Newsletter newsletter);

        /// <summary>
        /// M�todo repons�vel por alterar uma newsletter do sistema.
        /// </summary>
        /// <param name="newsletter">Objeto do tipo newsletter a ser alterado.</param>
        void Alterar(Newsletter newsletter);

        /// <summary>
        /// M�todo respons�vel por consultar newsletters do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="newsletter">Objeto do tipo newsletter que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos as newsletters cadastrados.</returns>
        List<Newsletter> Consultar(Newsletter newsletter, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos as newsletters do sistema.
        /// </summary>
        /// <returns>Lista contendo todos as newsletters cadastrados.</returns>
        List<Newsletter> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}