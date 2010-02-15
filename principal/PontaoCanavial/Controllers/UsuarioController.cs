using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloUsuario.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloUsuarioPonto.Processos;
using PontaoCanavial.Models.ModuloBasico.VOs;

namespace PontaoCanavial.Controllers
{
    public class UsuarioController : Controller
    {

        #region Incluir
        [HttpPost]
        public ActionResult Incluir(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                IUsuarioProcesso processo = UsuarioProcesso.Instance;
                processo.Incluir(usuario);
                processo.Confirmar();
                return Redirect("/");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(usuario);

        }

        public ActionResult Incluir()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }
        #endregion

        #region Alterar
        [HttpPost]
        public ActionResult Alterar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                string senha = usuario.Senha;
                usuario = ClasseAuxiliar.UsuarioLogado;
                usuario.Senha = senha;
                IUsuarioProcesso processo = UsuarioProcesso.Instance;
                processo.Alterar(usuario);
                processo.Confirmar();
                return Redirect("/");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(usuario);

        }

        public ActionResult Alterar()
        { 
            return View(ClasseAuxiliar.UsuarioLogado);
        }
        #endregion

        #region Controle de Acesso

        public ActionResult Deslogar()
        {
            Session.Remove("UsuarioLogado");

            return RedirectToAction("Index", "Ponto");
        }

        public ActionResult Logar()
        {
            Usuario usuario = new Usuario();
           
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Logar(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                IUsuarioProcesso processo = UsuarioProcesso.Instance;
                List<Usuario> usuarioLista = processo.Consultar(usuario,TipoPesquisa.E);
                if (usuarioLista.Count != 1)
                    ModelState.AddModelError("", "");
                else
                {
                    Session.Add("UsuarioLogado", usuarioLista[0]);
                    return RedirectToAction("Index", "PainelAdministrador");
                }
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(usuario);

        }
        #endregion
    }
}
