using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloImagem.Fabricas;
using PontaoCanavial.Models.ModuloImagem.Repositorios;

namespace PontaoCanavial.Models.ModuloImagem.Processos
{
    public class ImagemProcesso :Singleton<ImagemProcesso>, IImagemProcesso
    {
        #region Atributos
        private IImagemRepositorio imagemRepositorio = null;
        #endregion

        #region Construtor
        public ImagemProcesso()
        {
            imagemRepositorio = ImagemFabrica.IImagemInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Imagem imagem)
        {
            try
            {
                this.imagemRepositorio.Incluir(imagem);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Imagem imagem)
        {
            try
            {
                this.imagemRepositorio.Excluir(imagem);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.imagemRepositorio.Excluir(imagem);
        }

        public void Alterar(Imagem imagem)
        {
            this.imagemRepositorio.Alterar(imagem);
        }

        public List<Imagem> Consultar(Imagem imagem, TipoPesquisa tipoPesquisa)
        {
            List<Imagem> imagemList = this.imagemRepositorio.Consultar(imagem, tipoPesquisa);

            return imagemList;
        }

        public List<Imagem> Consultar()
        {
            List<Imagem> imagemList = imagemRepositorio.Consultar();

            return imagemList;
        }

        public void Confirmar()
        {
            imagemRepositorio.Confirmar();
        }

        #endregion
    }
        
}