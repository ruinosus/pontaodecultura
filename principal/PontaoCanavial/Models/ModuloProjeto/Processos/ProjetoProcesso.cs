using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloProjeto.Fabricas;
using PontaoCanavial.Models.ModuloProjeto.Repositorios;

namespace PontaoCanavial.Models.ModuloProjeto.Processos
{
    public class ProjetoProcesso :Singleton<ProjetoProcesso>, IProjetoProcesso
    {
        #region Atributos
        private IProjetoRepositorio projetoRepositorio = null;
        #endregion

        #region Construtor
        public ProjetoProcesso()
        {
            projetoRepositorio = ProjetoFabrica.IProjetoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Projeto projeto)
        {
            try
            {
                this.projetoRepositorio.Incluir(projeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Projeto projeto)
        {
            try
            {
                this.projetoRepositorio.Excluir(projeto);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.projetoRepositorio.Excluir(projeto);
        }

        public void Alterar(Projeto projeto)
        {
            this.projetoRepositorio.Alterar(projeto);
        }

        public List<Projeto> Consultar(Projeto projeto, TipoPesquisa tipoPesquisa)
        {
            List<Projeto> projetoList = this.projetoRepositorio.Consultar(projeto, tipoPesquisa);

            return projetoList;
        }

        public List<Projeto> Consultar()
        {
            List<Projeto> projetoList = projetoRepositorio.Consultar();

            return projetoList;
        }

        public void Confirmar()
        {
            projetoRepositorio.Confirmar();
        }

        #endregion
    }
       
}