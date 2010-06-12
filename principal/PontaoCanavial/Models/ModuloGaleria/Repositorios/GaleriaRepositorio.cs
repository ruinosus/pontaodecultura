using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using MySql.Data.MySqlClient;

namespace PontaoCanavial.Models.ModuloGaleria.Repositorios
{
    public class GaleriaRepositorio : IGaleriaRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Galeria galeria)
        {
            db.Galeria.InsertOnSubmit(galeria);
        }

        public void Excluir(Galeria galeria)
        {
            Galeria galeriaAux = new Galeria();
            galeriaAux.ID = galeria.ID;
            List<Galeria> resultado = this.Consultar(galeriaAux, TipoPesquisa.E);
            galeriaAux = resultado[0];

            db.Galeria.DeleteOnSubmit(galeriaAux);
        }

        public void Alterar(Galeria galeria)
        {
            Galeria galeriaAux = new Galeria();
            galeriaAux.ID = galeria.ID;
            List<Galeria> resultado = this.Consultar(galeriaAux, TipoPesquisa.E);
            galeriaAux = resultado[0];


            galeriaAux = resultado[0];
            galeriaAux.Descricao = galeria.Descricao;
			galeriaAux.Nome= galeria.Nome;
			galeriaAux.PontoID = galeria.PontoID;
			galeriaAux.UsuarioID = galeria.UsuarioID;
			galeriaAux.ImagemGrande = galeria.ImagemGrande;
			galeriaAux.ImagemMedia = galeria.ImagemMedia;
			galeriaAux.ImagemPequena = galeria.ImagemPequena;			
           
            Confirmar();
        }

        public List<Galeria> Consultar(Galeria galeria, TipoPesquisa tipoPesquisa)
        {
            List<Galeria> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (galeria.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == galeria.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(galeria.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(galeria.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }         

						if (!string.IsNullOrEmpty(galeria.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(galeria.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		

						if(galeria.PontoID!=null && galeria.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == galeria.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}						
						break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                       if (galeria.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == galeria.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(galeria.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Descricao.Contains(galeria.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }         

						if (!string.IsNullOrEmpty(galeria.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(galeria.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }     		

						if(galeria.PontoID!=null && galeria.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == galeria.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}	                     
						break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Galeria> Consultar()
        {
            return db.Galeria.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public GaleriaRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}