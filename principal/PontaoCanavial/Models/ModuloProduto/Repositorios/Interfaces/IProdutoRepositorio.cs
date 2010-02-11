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
        /// Método responsável por incluir um produto no sistema.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto a ser incluido.</param>
        void Incluir(Produto produto);

        /// <summary>
        /// Método responsável por excluir um produto do sistema.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto a ser excluido.</param>
        void Excluir(Produto produto);

        /// <summary>
        /// Método reponsável por alterar um produto do sistema.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto a ser alterado.</param>
        void Alterar(Produto produto);

        /// <summary>
        /// Método responsável por consultar produtos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="produto">Objeto do tipo produto que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os produtos cadastrados.</returns>
        List<Produto> Consultar(Produto produto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os produtos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os produtos cadastrados.</returns>
        List<Produto> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}