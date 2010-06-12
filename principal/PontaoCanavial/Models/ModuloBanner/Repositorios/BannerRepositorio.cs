using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using MySql.Data.MySqlClient;

namespace PontaoCanavial.Models.ModuloBanner.Repositorios
{
    public class BannerRepositorio : IBannerRepositorio
    {
        #region Atributos

        PontaoCanavialDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Banner banner)
        {
            db.Banner.InsertOnSubmit(banner);
        }

        public void Excluir(Banner banner)
        {
            Banner bannerAux = new Banner();
            bannerAux.ID = banner.ID;
            List<Banner> resultado = this.Consultar(bannerAux, TipoPesquisa.E);
            bannerAux = resultado[0];

            db.Banner.DeleteOnSubmit(bannerAux);
        }

        public void Alterar(Banner banner)
        {
            Banner bannerAux = new Banner();
            bannerAux.ID = banner.ID;
            List<Banner> resultado = this.Consultar(bannerAux, TipoPesquisa.E);
            bannerAux = resultado[0];


            bannerAux = resultado[0];
            bannerAux.Corpo = banner.Corpo;
            bannerAux.Nome = banner.Nome;
            bannerAux.Localizacao = banner.Localizacao;
            bannerAux.StatusBanner = banner.StatusBanner;
			bannerAux.PontoID = banner.PontoID;
			bannerAux.UsuarioID = banner.UsuarioID;

            Confirmar();
        }

        public List<Banner> Consultar(Banner banner, TipoPesquisa tipoPesquisa)
        {
            List<Banner> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (banner.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == banner.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(banner.Corpo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Corpo.Contains(banner.Corpo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        

                        if (banner.Localizacao.HasValue)
                        {

                            resultado = ((from p in resultado
                                          where
                                            p.Localizacao.HasValue && p.Localizacao.Value == banner.Localizacao.Value
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if (banner.StatusBanner.HasValue)
                        {

                            resultado = ((from p in resultado
                                          where
                                            p.StatusBanner.HasValue && p.StatusBanner.Value == banner.StatusBanner.Value
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(banner.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(banner.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(banner.PontoID!=null && banner.PontoID!=0)
						{
							 resultado = ((from p in resultado
                                          where
                                          p.PontoID == banner.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                         if (banner.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == banner.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(banner.Corpo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Corpo.Contains(banner.Corpo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }                        

                        if (banner.Localizacao.HasValue)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                            p.Localizacao.HasValue && p.Localizacao.Value == banner.Localizacao.Value
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if (banner.StatusBanner.HasValue)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                            p.StatusBanner.HasValue && p.StatusBanner.Value == banner.StatusBanner.Value
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(banner.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Nome.Contains(banner.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }
						
						if(banner.PontoID!=null && banner.PontoID!=0)
						{
							 resultado.AddRange((from p in resultado
                                          where
                                          p.PontoID == banner.PontoID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
						}
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Banner> Consultar()
        {
            return db.Banner.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public BannerRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new PontaoCanavialDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}