using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PontaoCanavial.Models.ModuloPonto.VOs;
using PontaoCanavial.Models.ModuloPonto.Repositorios;
using PontaoCanavial.Helpers;
using PontaoCanavial.Models.ModuloPonto.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class PontoController : Controller
    {

        public ActionResult Index(string nomeIdentificador)
        {
            if (!string.IsNullOrEmpty(nomeIdentificador))
            {
                //var pontinho = pontoRepositorio.ConsultarPorNomeIdentificador(nomeIdentificador);
                //if (pontinho != null && pontinho.NomeIdentificador != string.Empty)
                //{
                //    Session.Add("PontoFormViewModel", new PontoFormViewModel(pontinho, null));
                //    return View("IndexPontinho", new PontoFormViewModel(pontinho, null));
                //}
                //else
                return View("NaoEncontrado");
            }
            else
            {
                IPontoProcesso processo = PontoProcesso.Instance;

                Ponto p = new Ponto();
                p.EPontao = (int)Status.Pontao;
                List<Ponto> resultado = processo.Consultar();

                //var pontao = pontoRepositorio.ConsultarPontao();
                var pontao = resultado[0];
                //List<Ponto> pontinhos = pontoRepositorio.ConsultarTodos(true).ToList();
                List<Ponto> pontinhos = new List<Ponto>();
                Session.Add("PontoFormViewModel", new PontoFormViewModel(pontao, pontinhos));
                return View("IndexPontao", new PontoFormViewModel(pontao, pontinhos));

            }

        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult NoticiaLista()
        {
            return View("NoticiaLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult BuscaLista(string valor, int? id)
        {
            PontoFormViewModel pfvm = (PontoFormViewModel)Session["PontoFormViewModel"];
            //pfvm = pontoRepositorio.Buscar(pfvm, valor, 1);
            Session["PontoFormViewModel"] = pfvm;
            return View("BuscaLista", pfvm);
        }

        //pontinho
        public ActionResult PontinhoNoticiaLista()
        {
            PontoFormViewModel p = (PontoFormViewModel)Session["PontoFormViewModel"];

            return View("PontinhoNoticiaLista", p);
        }

        public ActionResult ProjetoLista()
        {
            return View("ProjetoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //pontinho
        public ActionResult PontinhoProjetoLista()
        {
            return View("PontinhoProjetoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult EventoLista()
        {
            return View("EventoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //pontinho
        public ActionResult PontinhoEventoLista()
        {
            return View("PontinhoEventoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult ProdutoLista()
        {
            return View("ProdutoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //pontinho
        public ActionResult PontinhoProdutoLista()
        {
            return View("PontinhoProdutoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult PontoDetalhe()
        {
            return View("PontoDetalhe", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //pontinho
        public ActionResult PontinhoDetalhe()
        {
            return View("PontinhoDetalhe", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }


        public ActionResult ProjetoDetalhe(int id)
        {

            //Projeto p = projetoRepositorio.GetProjeto(id);

            //if (p != null)
            //{
            //    PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
            //    pfvm.ProjetoDetalhe = p;
            //    return View("ProjetoDetalhe", pfvm);
            //}
            return View("NaoEncontrado");
        }

        //pontinho
        public ActionResult PontinhoProjetoDetalhe(int id)
        {

            //Projeto p = projetoRepositorio.GetProjeto(id);

            //if (p != null)
            //{
            //    PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
            //    pfvm.ProjetoDetalhe = p;
            //    return View("PontinhoProjetoDetalhe", pfvm);
            //}
            return View("NaoEncontrado");
        }

        public ActionResult EventoDetalhe(int id)
        {

            //Evento e = eventoRepositorio.GetEvento(id);

            //if (e != null)
            //{
            //    PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
            //    pfvm.EventoDetalhe = e;
            //    return View("EventoDetalhe", pfvm);
            //}
            return View("NaoEncontrado");
        }

        //Pontinho
        public ActionResult PontinhoEventoDetalhe(int id)
        {

            //Evento e = eventoRepositorio.GetEvento(id);

            //if (e != null)
            //{
            //    PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
            //    pfvm.EventoDetalhe = e;
            //    return View("PontinhoEventoDetalhe", pfvm);
            //}
            return View("NaoEncontrado");
        }

        public ActionResult NoticiaDetalhe(int id)
        {

            //Noticia n = noticiaRepositorio.GetNoticia(id);

            //if (n != null)
            //{
            //    PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
            //    pfvm.NoticiaDetalhe = n;
            //    return View("NoticiaDetalhe", pfvm);
            //}
            return View("NaoEncontrado");
        }

        //pontinho
        public ActionResult PontinhoNoticiaDetalhe(int id)
        {

            //Noticia n = noticiaRepositorio.GetNoticia(id);

            //if (n != null)
            //{
            //    PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
            //    pfvm.NoticiaDetalhe = n;
            //    return View("PontinhoNoticiaDetalhe", pfvm);
            //}
            return View("NaoEncontrado");
        }

        public ActionResult Incluir()
        {
            Ponto ponto = new Ponto();
            return View(ponto);
        }
        [HttpPost]
        public ActionResult Incluir(Ponto ponto)
        {
            if (ModelState.IsValid)
            {
                IPontoProcesso processo = PontoProcesso.Instance;
                ponto.EPontao = (int)Status.Pontinho;

                HttpPostedFileBase imgLogo = this.Request.Files.Get("logo");
                if (imgLogo != null)
                {
                    Int32 length = imgLogo.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imgLogo.InputStream.Read(imagemByte, 0, length);
                    ponto.Logo = imagemByte;
                }
                processo.Incluir(ponto);
                processo.Confirmar();
                return Redirect("/");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(ponto);

        }

       




        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Create(Ponto ponto)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        try
        //        {
        //            HttpPostedFileBase imgLogo = this.Request.Files.Get("imgLogo");
        //            if (imgLogo != null)
        //            {
        //                Int32 length = imgLogo.ContentLength;
        //                byte[] imagemByte = new byte[length];
        //                imgLogo.InputStream.Read(imagemByte, 0, length);
        //                ponto.Logo = imagemByte;
        //            }

        //            HttpPostedFileBase imagem = this.Request.Files.Get("imgPequena");
        //            if (imagem != null)
        //            {

        //                Int32 length = imagem.ContentLength;
        //                byte[] imagemByte = new byte[length];
        //                imagem.InputStream.Read(imagemByte, 0, length);
        //                ponto.ImagemPequena = imagemByte;
        //            }

        //            HttpPostedFileBase imagem2 = this.Request.Files.Get("imgMedia");
        //            if (imagem2 != null)
        //            {

        //                Int32 length = imagem2.ContentLength;
        //                byte[] imagemByte = new byte[length];
        //                imagem2.InputStream.Read(imagemByte, 0, length);
        //                ponto.ImagemMedia = imagemByte;
        //            }

        //            HttpPostedFileBase imagem3 = this.Request.Files.Get("imgGrande");
        //            if (imagem3 != null)
        //            {
        //                Int32 length = imagem3.ContentLength;
        //                byte[] imagemByte = new byte[length];
        //                imagem3.InputStream.Read(imagemByte, 0, length);
        //                ponto.ImagemGrande = imagemByte;
        //            }

        //            HttpPostedFileBase imagemCabecalho = this.Request.Files.Get("Cabecalho");
        //            if (imagemCabecalho != null)
        //            {
        //                Int32 length = imagemCabecalho.ContentLength;
        //                byte[] imagemByte = new byte[length];
        //                imagemCabecalho.InputStream.Read(imagemByte, 0, length);
        //                ponto.Cabecalho = imagemByte;
        //            }

        //            //ponto.PontoRepositorio = pontoRepositorio;
        //            //pontoRepositorio.Add(ponto);
        //            //pontoRepositorio.Save();

        //            return RedirectToAction("Index", new { nomeIdentificador = ponto.NomeIdentificador });
        //        }
        //        catch
        //        {
        //            //ModelState.AddModelErrors(ponto.GetRuleViolations());
        //        }
        //    }

        //    return View(new PontoFormViewModel(ponto, null));
        //}

        public ActionResult Edit(int id)
        {
            //Ponto ponto = pontoRepositorio.GetPonto(id);
            //ponto.Editando = true;

            //if (ponto != null)
            //    return View(new PontoFormViewModel(ponto, null));
            return View("NaoEncontrado");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            //Ponto ponto = pontoRepositorio.GetPonto(id);
            Ponto ponto = new Ponto();
            if (ModelState.IsValid)
            {

                try
                {
                    HttpPostedFileBase imgLogo = this.Request.Files.Get("imgLogo");
                    if (imgLogo != null)
                    {
                        Int32 length = imgLogo.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imgLogo.InputStream.Read(imagemByte, 0, length);
                        ponto.Logo = imagemByte;
                    }

                    HttpPostedFileBase imagem = this.Request.Files.Get("imgPequena");
                    if (imagem != null)
                    {

                        Int32 length = imagem.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        ponto.ImagemPequena = imagemByte;
                    }

                    HttpPostedFileBase imagem2 = this.Request.Files.Get("imgMedia");
                    if (imagem2 != null)
                    {

                        Int32 length = imagem2.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem2.InputStream.Read(imagemByte, 0, length);
                        ponto.ImagemMedia = imagemByte;
                    }

                    HttpPostedFileBase imagem3 = this.Request.Files.Get("imgGrande");
                    if (imagem3 != null)
                    {
                        Int32 length = imagem3.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem3.InputStream.Read(imagemByte, 0, length);
                        ponto.ImagemGrande = imagemByte;
                    }

                    HttpPostedFileBase imagemCabecalho = this.Request.Files.Get("Cabecalho");
                    if (imagemCabecalho != null)
                    {
                        Int32 length = imagemCabecalho.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagemCabecalho.InputStream.Read(imagemByte, 0, length);
                        ponto.Cabecalho = imagemByte;
                    }

                    //ponto.Editando = true;
                    //ponto.PontoRepositorio = pontoRepositorio;
                    //UpdateModel(ponto);
                    //pontoRepositorio.Save();

                    return RedirectToAction("Index", new { nomeIdentificador = ponto.NomeIdentificador });
                }
                catch
                {
                    //ModelState.AddModelErrors(ponto.GetRuleViolations());
                }
            }

            return View(new PontoFormViewModel(ponto, null));
        }
    }
}
