using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloNewsletter.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class NewsletterController: Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            INewsletterProcesso processo = NewsletterProcesso.Instance;
            Newsletter newsletter = new Newsletter();
            newsletter.PontoID = ClasseAuxiliar.PontoID;
            List<Newsletter> resultado = processo.Consultar(newsletter, TipoPesquisa.E);

            if (resultado != null)
                return View(resultado);
            else
                return View("NaoEncontrado");
        }

        #region Incluir
        public ActionResult Incluir()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            Newsletter newsletter = new Newsletter();

            newsletter.PontoID = ClasseAuxiliar.PontoID;
            return View(newsletter);
        }
        [HttpPost]
        public ActionResult Incluir(Newsletter newsletter)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                INewsletterProcesso processo = NewsletterProcesso.Instance;
                newsletter.PontoID = ClasseAuxiliar.PontoID;

                processo.Incluir(newsletter);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(newsletter);
        }
        #endregion

        #region Excluir


        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            INewsletterProcesso processo = NewsletterProcesso.Instance;
            Newsletter n = new Newsletter();
            n.ID = id;
            List<Newsletter> resultado = processo.Consultar(n, TipoPesquisa.E);
            if (resultado != null && resultado.Count == 1)
            {
                processo.Excluir(resultado[0]);
                processo.Confirmar();
            }

            return RedirectToAction("Listar");
        }
        #endregion       

        #region Alterar
        public ActionResult Alterar(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            INewsletterProcesso processo = NewsletterProcesso.Instance;
            Newsletter n = new Newsletter();
            n.ID = id;
            List<Newsletter> resultado = processo.Consultar(n, TipoPesquisa.E);
            if (resultado != null && resultado.Count == 1)
            {
                return View(resultado[0]);
            }
            else
                return View("NaoEncontrado");
        }

        [HttpPost]
        public ActionResult Alterar(int id, FormCollection collection)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            INewsletterProcesso processo = NewsletterProcesso.Instance;
            Newsletter newsletter = new Newsletter();
            newsletter.ID = id;
            List<Newsletter> resultado = processo.Consultar(newsletter, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            newsletter = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(newsletter);
           
                processo.Alterar(newsletter);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(newsletter);
        }
        #endregion
    }
}
