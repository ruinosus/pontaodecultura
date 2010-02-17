using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloPonto.VOs;
using PontaoCanavial.Models.ModuloPonto.Repositorios;
using PontaoCanavial.Models.ModuloPonto.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

namespace PontaoCanavial.Controllers
{
    public class PontoController : Controller
    {

        public ActionResult Index(string nomeIdentificador)
        {
            if (!string.IsNullOrEmpty(nomeIdentificador))
            {

                IPontoProcesso processo = PontoProcesso.Instance;

                Ponto p = new Ponto();
                p.EPontao = (int)Status.Pontinho;
                p.NomeIdentificador = nomeIdentificador;
                List<Ponto> resultado = processo.Consultar(p, TipoPesquisa.E);
                if (resultado != null && resultado.Count == 1)
                {
                    Session.Add("PontoFormViewModel", new PontoFormViewModel(resultado[0], new List<Ponto>()));
                    return View("IndexPontinho", new PontoFormViewModel(resultado[0], new List<Ponto>()));
                }
                else
                    return View("NaoEncontrado");
            }
            else
            {
                IPontoProcesso processo = PontoProcesso.Instance;

                Ponto p = new Ponto();
                p.EPontao = (int)Status.Pontao;
                List<Ponto> resultado = processo.Consultar(p, TipoPesquisa.E);

                var pontao = resultado[0];
                p.EPontao = (int)Status.Pontinho;
                List<Ponto> pontinhos = processo.Consultar(p, TipoPesquisa.E);
                Session.Add("PontoFormViewModel", new PontoFormViewModel(pontao, pontinhos));
                return View("IndexPontao", new PontoFormViewModel(pontao, pontinhos));

            }

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

        #region Incluir
        public ActionResult Incluir()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            Ponto ponto = new Ponto();
            return View(ponto);
        }
        [HttpPost]
        public ActionResult Incluir(Ponto ponto)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                IPontoProcesso processo = PontoProcesso.Instance;
                ponto.EPontao = (int)Status.Pontinho;

                #region Carregando Imagens
                HttpPostedFileBase imgLogo = this.Request.Files.Get("imglogo");
                if (imgLogo != null)
                {
                    Int32 length = imgLogo.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imgLogo.InputStream.Read(imagemByte, 0, length);
                    ponto.Logo = imagemByte;
                }

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    ponto.ImagemPequena = imagemByte;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    ponto.ImagemMedia = imagemByte;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    ponto.ImagemGrande = imagemByte;
                }

                HttpPostedFileBase imagemCabecalho = this.Request.Files.Get("cabecalho");
                if (imagemCabecalho != null)
                {
                    Int32 length = imagemCabecalho.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagemCabecalho.InputStream.Read(imagemByte, 0, length);
                    ponto.Cabecalho = imagemByte;
                }
                #endregion

                processo.Incluir(ponto);
                processo.Confirmar();
                return Redirect("/");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(ponto);

        }

        #endregion





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

        public ActionResult Alterar(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IPontoProcesso processo = PontoProcesso.Instance;
            Ponto p = new Ponto();
            p.ID = id;
            List<Ponto> resultado = processo.Consultar(p, TipoPesquisa.E);
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
            IPontoProcesso processo = PontoProcesso.Instance;
            Ponto ponto = new Ponto();
            ponto.ID = id;
            List<Ponto> resultado = processo.Consultar(ponto, TipoPesquisa.E);
            ponto = resultado[0];

            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                UpdateModel(ponto);

                #region Carregando Imagens
                HttpPostedFileBase imgLogo = this.Request.Files.Get("imglogo");
                if (imgLogo != null)
                {
                    Int32 length = imgLogo.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imgLogo.InputStream.Read(imagemByte, 0, length);
                    ponto.Logo = imagemByte;
                }

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    ponto.ImagemPequena = imagemByte;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    ponto.ImagemMedia = imagemByte;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    ponto.ImagemGrande = imagemByte;
                }

                HttpPostedFileBase imagemCabecalho = this.Request.Files.Get("cabecalho");
                if (imagemCabecalho != null)
                {
                    Int32 length = imagemCabecalho.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagemCabecalho.InputStream.Read(imagemByte, 0, length);
                    ponto.Cabecalho = imagemByte;
                }
                #endregion

                processo.Alterar(ponto);
                processo.Confirmar();
                return RedirectToAction("Index", new { nomeIdentificador = ponto.NomeIdentificador });
            }

            return View(ponto);
        }
    }
}
