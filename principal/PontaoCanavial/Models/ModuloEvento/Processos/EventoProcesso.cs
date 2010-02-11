using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloEvento.Repositorios;
using PontaoCanavial.Models.ModuloEvento.Fabricas;

namespace PontaoCanavial.Models.ModuloEvento.Processos
{
    public class EventoProcesso :Singleton<EventoProcesso>, IEventoProcesso
    {
        #region Atributos
        private IEventoRepositorio eventoRepositorio = null;
        #endregion

        #region Construtor
        public EventoProcesso()
        {
            eventoRepositorio = EventoFabrica.IEventoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Evento evento)
        {
            try
            {
                this.eventoRepositorio.Incluir(evento);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Evento evento)
        {
            try
            {
                this.eventoRepositorio.Excluir(evento);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.eventoRepositorio.Excluir(evento);
        }

        public void Alterar(Evento evento)
        {
            this.eventoRepositorio.Alterar(evento);
        }

        public List<Evento> Consultar(Evento evento, TipoPesquisa tipoPesquisa)
        {
            List<Evento> eventoList = this.eventoRepositorio.Consultar(evento, tipoPesquisa);

            return eventoList;
        }

        public List<Evento> Consultar()
        {
            List<Evento> eventoList = eventoRepositorio.Consultar();

            return eventoList;
        }

        public void Confirmar()
        {
            eventoRepositorio.Confirmar();
        }

        #endregion
    }
        
}