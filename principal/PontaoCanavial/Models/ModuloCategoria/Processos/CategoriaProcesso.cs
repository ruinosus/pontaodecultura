using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloCategoria.Fabricas;
using PontaoCanavial.Models.ModuloCategoria.Repositorios;

namespace PontaoCanavial.Models.ModuloCategoria.Processos
{
    public class CategoriaProcesso :Singleton<CategoriaProcesso>, ICategoriaProcesso
    {
        #region Atributos
        private ICategoriaRepositorio categoriaRepositorio = null;
        #endregion

        #region Construtor
        public CategoriaProcesso()
        {
            categoriaRepositorio = CategoriaFabrica.ICategoriaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Categoria categoria)
        {
            try
            {
                this.categoriaRepositorio.Incluir(categoria);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Categoria categoria)
        {
            try
            {
                this.categoriaRepositorio.Excluir(categoria);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.categoriaRepositorio.Excluir(categoria);
        }

        public void Alterar(Categoria categoria)
        {
            this.categoriaRepositorio.Alterar(categoria);
        }

        public List<Categoria> Consultar(Categoria categoria, TipoPesquisa tipoPesquisa)
        {
            List<Categoria> categoriaList = this.categoriaRepositorio.Consultar(categoria, tipoPesquisa);

            return categoriaList;
        }

        public List<Categoria> Consultar()
        {
            List<Categoria> categoriaList = categoriaRepositorio.Consultar();

            return categoriaList;
        }

        public void Confirmar()
        {
            categoriaRepositorio.Confirmar();
        }

        #endregion
    }
       
}