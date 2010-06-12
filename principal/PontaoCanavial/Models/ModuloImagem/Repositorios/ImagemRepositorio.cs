using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using MySql.Data.MySqlClient;

namespace PontaoCanavial.Models.ModuloImagem.Repositorios
{
    public class ImagemRepositorio : IImagemRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Imagem imagem)
        {
            db.Imagem.InsertOnSubmit(imagem);
        }

        public void Excluir(Imagem imagem)
        {
            Imagem imagemAux = new Imagem();
            imagemAux.ID = imagem.ID;
            List<Imagem> resultado = this.Consultar(imagemAux, TipoPesquisa.E);
            imagemAux = resultado[0];

            db.Imagem.DeleteOnSubmit(imagemAux);
        }

        public void Alterar(Imagem imagem)
        {
            Imagem imagemAux = new Imagem();
            imagemAux.ID = imagem.ID;
            List<Imagem> resultado = this.Consultar(imagemAux, TipoPesquisa.E);
            imagemAux = resultado[0];


            imagemAux = resultado[0];
            imagemAux.Descricao = imagem.Descricao;
			imagemAux.Nome= imagem.Nome;
			imagemAux.GaleriaID = imagem.GaleriaID;
			imagemAux.UsuarioID = imagem.UsuarioID;
			imagemAux.ImagemGrande = imagem.ImagemGrande;
			imagemAux.ImagemMedia = imagem.ImagemMedia;
			imagemAux.ImagemPequena = imagem.ImagemPequena;			
           
            Confirmar();
        }

        public List<Imagem> Consultar(Imagem imagem, TipoPesquisa tipoPesquisa)
        {
            List<Imagem> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (imagem.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == imagem.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(imagem.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(imagem.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }         

						if (!string.IsNullOrEmpty(imagem.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(imagem.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		

						if(imagem.GaleriaID!=null && imagem.GaleriaID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.GaleriaID == imagem.GaleriaID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                       if (imagem.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == imagem.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(imagem.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(imagem.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }         

						if (!string.IsNullOrEmpty(imagem.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(imagem.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		

						if(imagem.GaleriaID!=null && imagem.GaleriaID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.GaleriaID == imagem.GaleriaID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}	                     
						break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Imagem> Consultar()
        {
            return db.Imagem.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ImagemRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}