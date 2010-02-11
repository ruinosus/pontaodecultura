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
        /// Método responsável por incluir uma categoria no sistema.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria a ser incluido.</param>
        void Incluir(Categoria categoria);

        /// <summary>
        /// Método responsável por excluir uma categoria do sistema.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria a ser excluido.</param>
        void Excluir(Categoria categoria);

        /// <summary>
        /// Método reponsável por alterar uma categoria do sistema.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria a ser alterado.</param>
        void Alterar(Categoria categoria);

        /// <summary>
        /// Método responsável por consultar categorias do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="categoria">Objeto do tipo categoria que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos as categorias cadastrados.</returns>
        List<Categoria> Consultar(Categoria categoria, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos as categorias do sistema.
        /// </summary>
        /// <returns>Lista contendo todos as categorias cadastrados.</returns>
        List<Categoria> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}