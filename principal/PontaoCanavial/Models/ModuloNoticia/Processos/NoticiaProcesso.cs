using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloNoticia.Fabricas;
using PontaoCanavial.Models.ModuloNoticia.Repositorios;

namespace PontaoCanavial.Models.ModuloNoticia.Processos
{
    public class NoticiaProcesso :Singleton<NoticiaProcesso>, INoticiaProcesso
    {
        #region Atributos
        private INoticiaRepositorio noticiaRepositorio = null;
        #endregion

        #region Construtor
        public NoticiaProcesso()
        {
            noticiaRepositorio = NoticiaFabrica.INoticiaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Noticia noticia)
        {
            try
            {
                this.noticiaRepositorio.Incluir(noticia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Noticia noticia)
        {
            try
            {
                this.noticiaRepositorio.Excluir(noticia);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.noticiaRepositorio.Excluir(noticia);
        }

        public void Alterar(Noticia noticia)
        {
            this.noticiaRepositorio.Alterar(noticia);
        }

        public List<Noticia> Consultar(Noticia noticia, TipoPesquisa tipoPesquisa)
        {
            List<Noticia> noticiaList = this.noticiaRepositorio.Consultar(noticia, tipoPesquisa);

            return noticiaList;
        }

        public List<Noticia> Consultar()
        {
            List<Noticia> noticiaList = noticiaRepositorio.Consultar();

            return noticiaList;
        }

        public void Confirmar()
        {
            noticiaRepositorio.Confirmar();
        }

        #endregion
    }
       
}