using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloUsuario.Processos;

namespace PontaoCanavial.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }

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

        #region Incluir
        [HttpPost]
        public ActionResult Alterar(Usuario usuario)
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

        public ActionResult Alterar()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }
        #endregion



    }
}
