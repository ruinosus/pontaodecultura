using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloProjeto.Processos
{
    public interface IProjetoProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um projeto no sistema.
        /// </summary>
        /// <param name="projeto">Objeto do tipo projeto a ser incluido.</param>
        void Incluir(Projeto projeto);

        /// <summary>
        /// M�todo respons�vel por excluir um projeto do sistema.
        /// </summary>
        /// <param name="projeto">Objeto do tipo projeto a ser excluido.</param>
        void Excluir(Projeto projeto);

        /// <summary>
        /// M�todo repons�vel por alterar um projeto do sistema.
        /// </summary>
        /// <param name="projeto">Objeto do tipo projeto a ser alterado.</param>
        void Alterar(Projeto projeto);

        /// <summary>
        /// M�todo respons�vel por consultar projetos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="projeto">Objeto do tipo projeto que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os projetos cadastrados.</returns>
        List<Projeto> Consultar(Projeto projeto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os projetos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os projetos cadastrados.</returns>
        List<Projeto> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}