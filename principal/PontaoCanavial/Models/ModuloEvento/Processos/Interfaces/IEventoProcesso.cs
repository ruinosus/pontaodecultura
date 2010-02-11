using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PontaoCanavial.Controllers;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Models.ModuloEvento.Processos
{
    public interface IEventoProcesso
    {
        /// <summary>
        /// Método responsável por incluir um evento no sistema.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento a ser incluido.</param>
        void Incluir(Evento evento);

        /// <summary>
        /// Método responsável por excluir um evento do sistema.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento a ser excluido.</param>
        void Excluir(Evento evento);

        /// <summary>
        /// Método reponsável por alterar um evento do sistema.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento a ser alterado.</param>
        void Alterar(Evento evento);

        /// <summary>
        /// Método responsável por consultar eventos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os eventos cadastrados.</returns>
        List<Evento> Consultar(Evento evento, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os eventos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os eventos cadastrados.</returns>
        List<Evento> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}