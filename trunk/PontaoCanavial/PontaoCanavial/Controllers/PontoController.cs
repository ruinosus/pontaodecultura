using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.Repositorios;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Helpers;

namespace PontaoCanavial.Controllers
{
    [HandleError]
    public class PontoController : Controller
    {

        IPontoRepositorio pontoRepositorio;

        public PontoController()
            : this(new PontoRepositorio())
        {
        }

        public PontoController(IPontoRepositorio repositorio)
        {
            pontoRepositorio = repositorio;
        }
        //
        // GET: /Ponto/

        public ActionResult Index(string nomeIdentificador)
        {
            if (!string.IsNullOrEmpty(nomeIdentificador))
            {
                var pontinho = pontoRepositorio.ConsultarPorNomeIdentificador(nomeIdentificador);
                if (pontinho != null && pontinho.NomeIdentificador != string.Empty)
                    return View(pontinho);
                else
                    return View("NaoEncontrado");
            }
            else
            {
                var pontao = pontoRepositorio.ConsultarPontao();
                return View(pontao);

            }

        }

        //
        // GET: /Ponto/Details/5

        public ActionResult Details(int id)
        {
            
            return View();
        }      

        //
        // GET: /Ponto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ponto/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Ponto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ponto/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
