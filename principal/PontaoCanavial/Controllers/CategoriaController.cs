using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloCategoria.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class CategoriaController : Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            ICategoriaProcesso processo = CategoriaProcesso.Instance;
            Categoria categoria = new Categoria();
            //categoria.PontoID = ClasseAuxiliar.PontoID;
            List<Categoria> resultado = processo.Consultar(categoria, TipoPesquisa.E);

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
            Categoria categoria = new Categoria();

            //categoria.PontoID = ClasseAuxiliar.PontoID;
            return View(categoria);
        }
        [HttpPost]
        public ActionResult Incluir(Categoria categoria)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                ICategoriaProcesso processo = CategoriaProcesso.Instance;
                //noticia.PontoID = ClasseAuxiliar.PontoID;


                processo.Incluir(categoria);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(categoria);
        }
        #endregion

        #region Excluir


        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            ICategoriaProcesso processo = CategoriaProcesso.Instance;
            Categoria c = new Categoria();
            c.ID = id;
            List<Categoria> resultado = processo.Consultar(c, TipoPesquisa.E);
            if (resultado != null && resultado.Count == 1)
            {
                processo.Excluir(resultado[0]);
                processo.Confirmar();
            }

            return RedirectToAction("Listar");
        }
        #endregion             
    }
}
