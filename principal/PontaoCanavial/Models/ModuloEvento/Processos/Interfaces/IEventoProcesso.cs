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
        /// M�todo respons�vel por incluir um evento no sistema.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento a ser incluido.</param>
        void Incluir(Evento evento);

        /// <summary>
        /// M�todo respons�vel por excluir um evento do sistema.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento a ser excluido.</param>
        void Excluir(Evento evento);

        /// <summary>
        /// M�todo repons�vel por alterar um evento do sistema.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento a ser alterado.</param>
        void Alterar(Evento evento);

        /// <summary>
        /// M�todo respons�vel por consultar eventos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="evento">Objeto do tipo evento que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os eventos cadastrados.</returns>
        List<Evento> Consultar(Evento evento, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os eventos do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os eventos cadastrados.</returns>
        List<Evento> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}