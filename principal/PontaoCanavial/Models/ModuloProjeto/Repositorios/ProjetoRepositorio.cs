using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloProjeto.Repositorios
{
    public class ProjetoRepositorio : IProjetoRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Projeto projeto)
        {
            db.Projeto.InsertOnSubmit(projeto);
        }

        public void Excluir(Projeto projeto)
        {
            Projeto projetoAux = new Projeto();
            projetoAux.ID = projeto.ID;
            List<Projeto> resultado = this.Consultar(projetoAux, TipoPesquisa.E);
            projetoAux = resultado[0];

            db.Projeto.DeleteOnSubmit(projetoAux);
        }

        public void Alterar(Projeto projeto)
        {
            Projeto projetoAux = new Projeto();
            projetoAux.ID = projeto.ID;
            List<Projeto> resultado = this.Consultar(projetoAux, TipoPesquisa.E);
            projetoAux = resultado[0];


            projetoAux = resultado[0];
            projetoAux.Descricao = projeto.Descricao;
            projetoAux.Nome = projeto.Nome;
			projetoAux.PontoID = projeto.PontoID;
			projetoAux.UsuarioID = projeto.UsuarioID;
			projetoAux.ImagemGrande = projeto.ImagemGrande;
			projetoAux.ImagemMedia = projeto.ImagemMedia;
			projetoAux.ImagemPequena = projeto.ImagemPequena;

            Confirmar();
        }

        public List<Projeto> Consultar(Projeto projeto, TipoPesquisa tipoPesquisa)
        {
            List<Projeto> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (projeto.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == projeto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(projeto.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(projeto.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }  

                        if (!string.IsNullOrEmpty(projeto.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(projeto.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(projeto.PontoID!=null && projeto.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == projeto.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                         if (projeto.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == projeto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(projeto.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(projeto.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        
                       
                        if (!string.IsNullOrEmpty(projeto.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(projeto.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(projeto.PontoID!=null && projeto.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == projeto.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Projeto> Consultar()
        {
            return db.Projeto.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ProjetoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}