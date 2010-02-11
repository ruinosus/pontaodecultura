using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloBanner.Fabricas;
using PontaoCanavial.Models.ModuloBanner.Repositorios;

namespace PontaoCanavial.Models.ModuloBanner.Processos
{
    public class BannerProcesso :Singleton<BannerProcesso>, IBannerProcesso
    {
        #region Atributos
        private IBannerRepositorio bannerRepositorio = null;
        #endregion

        #region Construtor
        public BannerProcesso()
        {
            bannerRepositorio = BannerFabrica.IBannerInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Banner banner)
        {
            try
            {
                this.bannerRepositorio.Incluir(banner);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Banner banner)
        {
            try
            {
                this.bannerRepositorio.Excluir(banner);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.bannerRepositorio.Excluir(banner);
        }

        public void Alterar(Banner banner)
        {
            this.bannerRepositorio.Alterar(banner);
        }

        public List<Banner> Consultar(Banner banner, TipoPesquisa tipoPesquisa)
        {
            List<Banner> bannerList = this.bannerRepositorio.Consultar(banner, tipoPesquisa);

            return bannerList;
        }

        public List<Banner> Consultar()
        {
            List<Banner> bannerList = bannerRepositorio.Consultar();

            return bannerList;
        }

        public void Confirmar()
        {
            bannerRepositorio.Confirmar();
        }

        #endregion
    }
       
}