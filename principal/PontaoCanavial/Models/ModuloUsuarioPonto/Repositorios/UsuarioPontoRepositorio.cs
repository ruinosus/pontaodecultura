using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloUsuarioPonto.Repositorios
{
    public class UsuarioPontoRepositorio : IUsuarioPontoRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(UsuarioPonto usuarioPonto)
        {
            db.UsuarioPonto.InsertOnSubmit(usuarioPonto);
        }

        public void Excluir(UsuarioPonto usuarioPonto)
        {
            UsuarioPonto usuarioPontoAux = new UsuarioPonto();
            usuarioPontoAux.ID = usuarioPonto.ID;
            List<UsuarioPonto> resultado = this.Consultar(usuarioPontoAux, TipoPesquisa.E);
            usuarioPontoAux = resultado[0];

            db.UsuarioPonto.DeleteOnSubmit(usuarioPontoAux);
        }

        public void Alterar(UsuarioPonto usuarioPonto)
        {
            UsuarioPonto usuarioPontoAux = new UsuarioPonto();
            usuarioPontoAux.ID = usuarioPonto.ID;
            List<UsuarioPonto> resultado = this.Consultar(usuarioPontoAux, TipoPesquisa.E);
            usuarioPontoAux = resultado[0];


            usuarioPontoAux = resultado[0];
			usuarioPontoAux.PontoID = usuarioPonto.PontoID;
			usuarioPontoAux.UsuarioID = usuarioPonto.UsuarioID;		

            Confirmar();
        }

        public List<UsuarioPonto> Consultar(UsuarioPonto usuarioPonto, TipoPesquisa tipoPesquisa)
        {
            List<UsuarioPonto> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (usuarioPonto.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == usuarioPonto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }                       
						
						if(usuarioPonto.PontoID!=null && usuarioPonto.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == usuarioPonto.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}	

						if(usuarioPonto.UsuarioID!=null && usuarioPonto.UsuarioID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.UsuarioID == usuarioPonto.UsuarioID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (usuarioPonto.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == usuarioPonto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }                       
						
						if(usuarioPonto.PontoID!=null && usuarioPonto.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == usuarioPonto.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}	

						if(usuarioPonto.UsuarioID!=null && usuarioPonto.UsuarioID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.UsuarioID == usuarioPonto.UsuarioID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}					
						
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<UsuarioPonto> Consultar()
        {
            return db.UsuarioPonto.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public UsuarioPontoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}