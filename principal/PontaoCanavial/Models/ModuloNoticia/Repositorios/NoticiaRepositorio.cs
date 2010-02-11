using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloNoticia.Repositorios
{
    public class NoticiaRepositorio : INoticiaRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Noticia noticia)
        {
            db.Noticia.InsertOnSubmit(noticia);
        }

        public void Excluir(Noticia noticia)
        {
            Noticia noticiaAux = new Noticia();
            noticiaAux.ID = noticia.ID;
            List<Noticia> resultado = this.Consultar(noticiaAux, TipoPesquisa.E);
            noticiaAux = resultado[0];

            db.Noticia.DeleteOnSubmit(noticiaAux);
        }

        public void Alterar(Noticia noticia)
        {
            Noticia noticiaAux = new Noticia();
            noticiaAux.ID = noticia.ID;
            List<Noticia> resultado = this.Consultar(noticiaAux, TipoPesquisa.E);
            noticiaAux = resultado[0];


            noticiaAux = resultado[0];
            noticiaAux.Titulo = noticia.Titulo;
			noticiaAux.DataCriacao = noticia.DataCriacao;
			noticiaAux.Corpo = noticia.Corpo;
			noticiaAux.Preview = noticia.Preview;
			noticiaAux.ImagemGrande = noticia.ImagemGrande;
			noticiaAux.ImagemMedia = noticia.ImagemMedia;
			noticiaAux.ImagemPequena = noticia.ImagemPequena;
			noticiaAux.PontoID = noticia.PontoID;
			noticiaAux.UsuarioID = noticia.UsuarioID;
           
            Confirmar();
        }

        public List<Noticia> Consultar(Noticia noticia, TipoPesquisa tipoPesquisa)
        {
            List<Noticia> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (noticia.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == noticia.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(noticia.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(noticia.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }         

						if (!string.IsNullOrEmpty(noticia.Corpo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Corpo.Contains(noticia.Corpo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		
						
						if (!string.IsNullOrEmpty(noticia.Preview))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Preview.Contains(noticia.Preview)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		

						if(noticia.DataCriacao.HasValue)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.DataCriacao != null &&  p.DataCriacao.Value == noticia.DataCriacao.Value
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
						
						if(noticia.PontoID!=null && noticia.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == noticia.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                       if (noticia.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == noticia.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(noticia.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Titulo.Contains(noticia.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }         

						if (!string.IsNullOrEmpty(noticia.Corpo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Corpo.Contains(noticia.Corpo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		
						
						if (!string.IsNullOrEmpty(noticia.Preview))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Preview.Contains(noticia.Preview)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		

						if(noticia.DataCriacao.HasValue)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.DataCriacao != null &&  p.DataCriacao.Value == noticia.DataCriacao.Value
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
						
						if(noticia.PontoID!=null && noticia.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == noticia.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Noticia> Consultar()
        {
            return db.Noticia.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public NoticiaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}