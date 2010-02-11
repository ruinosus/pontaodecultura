using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloVideo.Processos
{
    public interface IVideoProcesso
    {
        /// <summary>
        /// Método responsável por incluir um video no sistema.
        /// </summary>
        /// <param name="video">Objeto do tipo video a ser incluido.</param>
        void Incluir(Video video);

        /// <summary>
        /// Método responsável por excluir um video do sistema.
        /// </summary>
        /// <param name="video">Objeto do tipo video a ser excluido.</param>
        void Excluir(Video video);

        /// <summary>
        /// Método reponsável por alterar um video do sistema.
        /// </summary>
        /// <param name="video">Objeto do tipo video a ser alterado.</param>
        void Alterar(Video video);

        /// <summary>
        /// Método responsável por consultar videos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="video">Objeto do tipo video que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os videos cadastrados.</returns>
        List<Video> Consultar(Video video, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os videos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os videos cadastrados.</returns>
        List<Video> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}