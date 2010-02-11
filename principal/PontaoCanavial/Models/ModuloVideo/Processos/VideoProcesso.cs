using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloVideo.Fabricas;
using PontaoCanavial.Models.ModuloVideo.Repositorios;

namespace PontaoCanavial.Models.ModuloVideo.Processos
{
    public class VideoProcesso :Singleton<VideoProcesso>, IVideoProcesso
    {
        #region Atributos
        private IVideoRepositorio videoRepositorio = null;
        #endregion

        #region Construtor
        public VideoProcesso()
        {
            videoRepositorio = VideoFabrica.IVideoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Video video)
        {
            try
            {
                this.videoRepositorio.Incluir(video);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Video video)
        {
            try
            {
                this.videoRepositorio.Excluir(video);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.videoRepositorio.Excluir(video);
        }

        public void Alterar(Video video)
        {
            this.videoRepositorio.Alterar(video);
        }

        public List<Video> Consultar(Video video, TipoPesquisa tipoPesquisa)
        {
            List<Video> videoList = this.videoRepositorio.Consultar(video, tipoPesquisa);

            return videoList;
        }

        public List<Video> Consultar()
        {
            List<Video> videoList = videoRepositorio.Consultar();

            return videoList;
        }

        public void Confirmar()
        {
            videoRepositorio.Confirmar();
        }

        #endregion
    }
      
}