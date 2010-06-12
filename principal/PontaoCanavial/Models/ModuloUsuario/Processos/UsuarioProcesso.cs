using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

using PontaoCanavial.Models.ModuloBasico.Singleton;
using PontaoCanavial.Models.ModuloUsuario.Fabricas;
using PontaoCanavial.Models.ModuloUsuario.Repositorios;

namespace PontaoCanavial.Models.ModuloUsuario.Processos
{
    public class UsuarioProcesso :Singleton<UsuarioProcesso>, IUsuarioProcesso
    {
        #region Atributos
        private IUsuarioRepositorio usuarioRepositorio = null;
        #endregion

        #region Construtor
        public UsuarioProcesso()
        {
            usuarioRepositorio = UsuarioFabrica.IUsuarioInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Usuario usuario)
        {
            try
            {
                this.usuarioRepositorio.Incluir(usuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Usuario usuario)
        {
            try
            {
                this.usuarioRepositorio.Excluir(usuario);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.usuarioRepositorio.Excluir(usuario);
        }

        public void Alterar(Usuario usuario)
        {
            this.usuarioRepositorio.Alterar(usuario);
        }

        public List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa)
        {
            List<Usuario> usuarioList = this.usuarioRepositorio.Consultar(usuario, tipoPesquisa);

            return usuarioList;
        }

        public List<Usuario> Consultar()
        {
            List<Usuario> usuarioList = usuarioRepositorio.Consultar();

            return usuarioList;
        }

        public void Confirmar()
        {
            usuarioRepositorio.Confirmar();
        }

        #endregion
    }
       
}