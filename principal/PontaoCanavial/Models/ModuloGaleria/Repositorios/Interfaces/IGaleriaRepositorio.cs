using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloGaleria.Repositorios
{
    public interface IGaleriaRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma galeria no sistema.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria a ser incluido.</param>
        void Incluir(Galeria galeria);

        /// <summary>
        /// M�todo respons�vel por excluir uma galeria do sistema.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria a ser excluido.</param>
        void Excluir(Galeria galeria);

        /// <summary>
        /// M�todo repons�vel por alterar uma galeria do sistema.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria a ser alterado.</param>
        void Alterar(Galeria galeria);

        /// <summary>
        /// M�todo respons�vel por consultar galerias do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos as galerias cadastrados.</returns>
        List<Galeria> Consultar(Galeria galeria, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos as galerias do sistema.
        /// </summary>
        /// <returns>Lista contendo todos as galerias cadastrados.</returns>
        List<Galeria> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}