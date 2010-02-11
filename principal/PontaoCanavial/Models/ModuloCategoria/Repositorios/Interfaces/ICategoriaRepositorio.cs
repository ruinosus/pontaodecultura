using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloCategoria.Repositorios
{
    public interface ICategoriaRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma categoria no sistema.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria a ser incluido.</param>
        void Incluir(Categoria categoria);

        /// <summary>
        /// M�todo respons�vel por excluir uma categoria do sistema.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria a ser excluido.</param>
        void Excluir(Categoria categoria);

        /// <summary>
        /// M�todo repons�vel por alterar uma categoria do sistema.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria a ser alterado.</param>
        void Alterar(Categoria categoria);

        /// <summary>
        /// M�todo respons�vel por consultar categorias do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos as categorias cadastrados.</returns>
        List<Categoria> Consultar(Categoria categoria, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos as categorias do sistema.
        /// </summary>
        /// <returns>Lista contendo todos as categorias cadastrados.</returns>
        List<Categoria> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}