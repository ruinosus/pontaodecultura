using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloUsuarioPonto.Fabricas;
using PontaoCanavial.Models.ModuloUsuarioPonto.Repositorios;

namespace PontaoCanavial.Models.ModuloUsuarioPonto.Processos
{
    public class UsuarioPontoProcesso :Singleton<UsuarioPontoProcesso>, IUsuarioPontoProcesso
    {
        #region Atributos
        private IUsuarioPontoRepositorio usuarioPontoRepositorio = null;
        #endregion

        #region Construtor
        public UsuarioPontoProcesso()
        {
            usuarioPontoRepositorio = UsuarioPontoFabrica.IUsuarioPontoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(UsuarioPonto usuarioPonto)
        {
            try
            {
                this.usuarioPontoRepositorio.Incluir(usuarioPonto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(UsuarioPonto usuarioPonto)
        {
            try
            {
                this.usuarioPontoRepositorio.Excluir(usuarioPonto);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.usuarioPontoRepositorio.Excluir(usuarioPonto);
        }

        public void Alterar(UsuarioPonto usuarioPonto)
        {
            this.usuarioPontoRepositorio.Alterar(usuarioPonto);
        }

        public List<UsuarioPonto> Consultar(UsuarioPonto usuarioPonto, TipoPesquisa tipoPesquisa)
        {
            List<UsuarioPonto> usuarioPontoList = this.usuarioPontoRepositorio.Consultar(usuarioPonto, tipoPesquisa);

            return usuarioPontoList;
        }

        public List<UsuarioPonto> Consultar()
        {
            List<UsuarioPonto> usuarioPontoList = usuarioPontoRepositorio.Consultar();

            return usuarioPontoList;
        }

        public void Confirmar()
        {
            usuarioPontoRepositorio.Confirmar();
        }

        #endregion
    }
        
}