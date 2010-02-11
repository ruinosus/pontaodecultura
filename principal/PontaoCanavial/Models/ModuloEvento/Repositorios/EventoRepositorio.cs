using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloEvento.Repositorios
{
    public class EventoRepositorio : IEventoRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Evento evento)
        {
            db.Evento.InsertOnSubmit(evento);
        }

        public void Excluir(Evento evento)
        {
            Evento eventoAux = new Evento();
            eventoAux.ID = evento.ID;
            List<Evento> resultado = this.Consultar(eventoAux, TipoPesquisa.E);
            eventoAux = resultado[0];

            db.Evento.DeleteOnSubmit(eventoAux);
        }

        public void Alterar(Evento evento)
        {
            Evento eventoAux = new Evento();
            eventoAux.ID = evento.ID;
            List<Evento> resultado = this.Consultar(eventoAux, TipoPesquisa.E);
            eventoAux = resultado[0];


            eventoAux = resultado[0];
            eventoAux.Descricao = evento.Descricao;
            eventoAux.Nome = evento.Nome;
            eventoAux.DataEvento = evento.DataEvento;
			eventoAux.PontoID = evento.PontoID;
			eventoAux.UsuarioID = evento.UsuarioID;
			eventoAux.ImagemGrande = evento.ImagemGrande;
			eventoAux.ImagemMedia = evento.ImagemMedia;
			eventoAux.ImagemPequena = evento.ImagemPequena;

            Confirmar();
        }

        public List<Evento> Consultar(Evento evento, TipoPesquisa tipoPesquisa)
        {
            List<Evento> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (evento.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == evento.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(evento.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(evento.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        

                        if (evento.DataEvento.HasValue)
                        {

                            resultado = ((from p in resultado
                                          where
                                            p.DataEvento.HasValue && p.DataEvento.Value == evento.DataEvento.Value
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }					
						

                        if (!string.IsNullOrEmpty(evento.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(evento.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(evento.PontoID!=null && evento.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == evento.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                         if (evento.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == evento.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(evento.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(evento.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        

                        if (evento.DataEvento.HasValue)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                            p.DataEvento.HasValue && p.DataEvento.Value == evento.DataEvento.Value
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }					
						

                        if (!string.IsNullOrEmpty(evento.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(evento.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(evento.PontoID!=null && evento.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == evento.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Evento> Consultar()
        {
            return db.Evento.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public EventoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}