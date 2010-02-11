using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloProduto.Repositorios
{
    public interface IProdutoRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir um produto no sistema.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto a ser incluido.</param>
        void Incluir(Produto produto);

        /// <summary>
        /// M�todo respons�vel por excluir um produto do sistema.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto a ser excluido.</param>
        void Excluir(Produto produto);

        /// <summary>
        /// M�todo repons�vel por alterar um produto do sistema.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto a ser alterado.</param>
        void Alterar(Produto produto);

        /// <summary>
        /// M�todo respons�vel por consultar produtos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os produtos cadastrados.</returns>
        List<Produto> Consultar(Produto produto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os produtos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os produtos cadastrados.</returns>
        List<Produto> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}