using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloBanner.Processos
{
    public interface IBannerProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um banner no sistema.
        /// </summary>
        /// <param name="banner">Objeto do tipo banner a ser incluido.</param>
        void Incluir(Banner banner);

        /// <summary>
        /// M�todo respons�vel por excluir um banner do sistema.
        /// </summary>
        /// <param name="banner">Objeto do tipo banner a ser excluido.</param>
        void Excluir(Banner banner);

        /// <summary>
        /// M�todo repons�vel por alterar um banner do sistema.
        /// </summary>
        /// <param name="banner">Objeto do tipo banner a ser alterado.</param>
        void Alterar(Banner banner);

        /// <summary>
        /// M�todo respons�vel por consultar banners do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="banner">Objeto do tipo banner que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os banners cadastrados.</returns>
        List<Banner> Consultar(Banner banner, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os banners do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os banners cadastrados.</returns>
        List<Banner> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}