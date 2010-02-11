using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloNoticia.Repositorios
{
    public interface INoticiaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma noticia no sistema.
        /// </summary>
        /// <param name="noticia">Objeto do tipo noticia a ser incluido.</param>
        void Incluir(Noticia noticia);

        /// <summary>
        /// Método responsável por excluir uma noticia do sistema.
        /// </summary>
        /// <param name="noticia">Objeto do tipo noticia a ser excluido.</param>
        void Excluir(Noticia noticia);

        /// <summary>
        /// Método reponsável por alterar uma noticia do sistema.
        /// </summary>
        /// <param name="noticia">Objeto do tipo noticia a ser alterado.</param>
        void Alterar(Noticia noticia);

        /// <summary>
        /// Método responsável por consultar noticias do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="noticia">Objeto do tipo noticia que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos as noticias cadastrados.</returns>
        List<Noticia> Consultar(Noticia noticia, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos as noticias do sistema.
        /// </summary>
        /// <returns>Lista contendo todos as noticias cadastrados.</returns>
        List<Noticia> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}