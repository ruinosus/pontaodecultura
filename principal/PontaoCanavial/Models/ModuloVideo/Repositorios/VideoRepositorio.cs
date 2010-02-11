using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;

namespace PontaoCanavial.Models.ModuloVideo.Repositorios
{
    public class VideoRepositorio : IVideoRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Video video)
        {
            db.Video.InsertOnSubmit(video);
        }

        public void Excluir(Video video)
        {
            Video videoAux = new Video();
            videoAux.ID = video.ID;
            List<Video> resultado = this.Consultar(videoAux, TipoPesquisa.E);
            videoAux = resultado[0];

            db.Video.DeleteOnSubmit(videoAux);
        }

        public void Alterar(Video video)
        {
            Video videoAux = new Video();
            videoAux.ID = video.ID;
            List<Video> resultado = this.Consultar(videoAux, TipoPesquisa.E);
            videoAux = resultado[0];


            videoAux = resultado[0];
            videoAux.Descricao = video.Descricao;
            videoAux.Conteudo = video.Conteudo;
			videoAux.Titulo = video.Titulo;
      		videoAux.PontoID = video.PontoID;
			videoAux.UsuarioID = video.UsuarioID;

            Confirmar();
        }

        public List<Video> Consultar(Video video, TipoPesquisa tipoPesquisa)
        {
            List<Video> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (video.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == video.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(video.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(video.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }  

                        if (!string.IsNullOrEmpty(video.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(video.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						 if (!string.IsNullOrEmpty(video.Conteudo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Conteudo.Contains(video.Conteudo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(video.PontoID!=null && video.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == video.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
						
						
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (video.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == video.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(video.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(video.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }  

                        if (!string.IsNullOrEmpty(video.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Titulo.Contains(video.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						 if (!string.IsNullOrEmpty(video.Conteudo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Conteudo.Contains(video.Conteudo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(video.PontoID!=null && video.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == video.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
						
						
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Video> Consultar()
        {
            return db.Video.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public VideoRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}