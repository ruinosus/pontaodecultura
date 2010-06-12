using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloProduto.Fabricas;
using PontaoCanavial.Models.ModuloProduto.Repositorios;

namespace PontaoCanavial.Models.ModuloProduto.Processos
{
    public class ProdutoProcesso :Singleton<ProdutoProcesso>, IProdutoProcesso
    {
        #region Atributos
        private IProdutoRepositorio produtoRepositorio = null;
        #endregion

        #region Construtor
        public ProdutoProcesso()
        {
            produtoRepositorio = ProdutoFabrica.IProdutoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Produto produto)
        {
            try
            {
                this.produtoRepositorio.Incluir(produto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Produto produto)
        {
            try
            {
                this.produtoRepositorio.Excluir(produto);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.produtoRepositorio.Excluir(produto);
        }

        public void Alterar(Produto produto)
        {
            this.produtoRepositorio.Alterar(produto);
        }

        public List<Produto> Consultar(Produto produto, TipoPesquisa tipoPesquisa)
        {
            List<Produto> produtoList = this.produtoRepositorio.Consultar(produto, tipoPesquisa);

            return produtoList;
        }

        public List<Produto> Consultar()
        {
            List<Produto> produtoList = produtoRepositorio.Consultar();

            return produtoList;
        }

        public void Confirmar()
        {
            produtoRepositorio.Confirmar();
        }

        #endregion
    }
       
    
}