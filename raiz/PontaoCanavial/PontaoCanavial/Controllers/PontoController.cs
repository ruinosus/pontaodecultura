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
using System.IO;

namespace PontaoCanavial.Controllers
{
    #region ViewModel Classes

    public class PontoFormViewModel
    {
        #region Propriedades

        public Ponto Ponto { get; private set; }
        public List<Ponto> Pontinhos { get; private set; }
        public Noticia NoticiaDetalhe { get; set; }
        public Projeto ProjetoDetalhe { get; set; }
        public Galeria GaleriaDetalhe { get; set; }
        public Produto ProdutoDetalhe { get; set; }
        public Evento EventoDetalhe { get; set; }
       

        #endregion

        #region Construtores

        public PontoFormViewModel(Ponto ponto, List<Ponto> pontinhos)
        {
            Ponto = ponto;
            Pontinhos = pontinhos;            
        }
        #endregion
    }
    #endregion

    [HandleError]
    public class PontoController : Controller
    {
        private byte[] ConverterByte(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            // Create a byte array of file stream length  
            byte[] ImageData = new byte[fs.Length];
            //Read block of bytes from stream into the byte array   
            fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
            //Close the File Stream  
            fs.Close();
            return ImageData;
            //return the byte data
        }

        IPontoRepositorio pontoRepositorio;
        INoticiaRepositorio noticiaRepositorio;
        IProdutoRepositorio produtoRepositorio;
        IProjetoRepositorio projetoRepositorio;
        IGaleriaRepositorio galeriaRepositorio;
        IEventoRepositorio eventoRepositorio;

        public PontoController()
            : this(new PontoRepositorio(), new NoticiaRepositorio(), new ProjetoRepositorio(), new GaleriaRepositorio(), new ProdutoRepositorio(), new EventoRepositorio())
        {
        }

        public PontoController(IPontoRepositorio pontoRepositorio, INoticiaRepositorio noticiaRepositorio, IProjetoRepositorio projetoRepositorio, IGaleriaRepositorio galeriaRepositorio, IProdutoRepositorio produtoRepositorio, IEventoRepositorio eventoRepositorio)
        {
            this.pontoRepositorio = pontoRepositorio;
            this.noticiaRepositorio = noticiaRepositorio;
            this.produtoRepositorio = produtoRepositorio;
            this.galeriaRepositorio = galeriaRepositorio;
            this.projetoRepositorio = projetoRepositorio;
            this.eventoRepositorio = eventoRepositorio;

        }

        public ActionResult Index(string nomeIdentificador)
        {
            if (!string.IsNullOrEmpty(nomeIdentificador))
            {
                var pontinho = pontoRepositorio.ConsultarPorNomeIdentificador(nomeIdentificador);
                if (pontinho != null && pontinho.NomeIdentificador != string.Empty)
                {
                    Session.Add("PontoFormViewModel", new PontoFormViewModel(pontinho, null));
                    return View("IndexPontinho", new PontoFormViewModel(pontinho, null));
                }
                else
                    return View("NaoEncontrado");
            }
            else
            {
                var pontao = pontoRepositorio.ConsultarPontao();
                List<Ponto> pontinhos = pontoRepositorio.ConsultarTodos(true).ToList();
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

        public ActionResult ProjetoLista()
        {
            return View("ProjetoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult EventoLista()
        {
            return View("EventoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult ProdutoLista()
        {
            return View("ProdutoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        public ActionResult PontoDetalhe()
        {
            return View("PontoDetalhe", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }


        public ActionResult ProjetoDetalhe(int id)
        {

            Projeto p = projetoRepositorio.GetProjeto(id);

            if (p != null)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.ProjetoDetalhe = p;
                return View("ProjetoDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        public ActionResult EventoDetalhe(int id)
        {

            Evento e = eventoRepositorio.GetEvento(id);

            if (e != null)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.EventoDetalhe = e;
                return View("EventoDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        public ActionResult NoticiaDetalhe(int id)
        {

            Noticia n = noticiaRepositorio.GetNoticia(id);

            if (n != null)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.NoticiaDetalhe = n;
                return View("NoticiaDetalhe", pfvm);
            }
                return View("NaoEncontrado");
        }


        public ActionResult Create()
        {
            Ponto ponto = new Ponto();
            return View(new PontoFormViewModel(ponto, null));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Ponto ponto)
        {
            if (ModelState.IsValid)
            {

                try
                {

                    HttpPostedFileBase teste = this.Request.Files.Get("imgLogo");
                    if (this.Request.Files.Count > 0)
                    {

                        HttpPostedFileBase file = this.Request.Files[0];
                        Int32 length = file.ContentLength;
                        byte[] logo = new byte[length];
                        file.InputStream.Read(logo, 0, length);
                        ponto.Logo = logo;
                    }

                    if (Session["ImagemLogo"] != null)
                    {
                        ponto.Logo = (byte[])Session["ImagemLogo"];
                    }


                    HttpPostedFileBase teste1 = this.Request.Files.Get("imgPequena");
                    if (this.Request.Files.Count > 0)
                    {

                        HttpPostedFileBase file = this.Request.Files[0];
                        Int32 length = file.ContentLength;
                        byte[] imagemPequena = new byte[length];
                        file.InputStream.Read(imagemPequena, 0, length);
                        ponto.ImagemPequena = imagemPequena;
                    }

                    if (Session["ImagemPequena"] != null)
                    {
                        ponto.ImagemPequena = (byte[])Session["ImagemPequena"];
                    }

                    HttpPostedFileBase teste2 = this.Request.Files.Get("imgMedia");
                    if (this.Request.Files.Count > 0)
                    {

                        HttpPostedFileBase file = this.Request.Files[0];
                        Int32 length = file.ContentLength;
                        byte[] imagemMedia = new byte[length];
                        file.InputStream.Read(imagemMedia, 0, length);
                        ponto.ImagemMedia = imagemMedia;
                    }

                    if (Session["ImagemMedia"] != null)
                    {
                        ponto.ImagemMedia = (byte[])Session["ImagemMedia"];
                    }

                    HttpPostedFileBase teste3 = this.Request.Files.Get("imgGrande");
                    if (this.Request.Files.Count > 0)
                    {

                        HttpPostedFileBase file = this.Request.Files[0];
                        Int32 length = file.ContentLength;
                        byte[] imagemGrande = new byte[length];
                        file.InputStream.Read(imagemGrande, 0, length);
                        ponto.ImagemGrande = imagemGrande;
                    }

                    if (Session["ImagemGrande"] != null)
                    {
                        ponto.ImagemGrande = (byte[])Session["ImagemGrande"];
                    }

                    ponto.PontoRepositorio = pontoRepositorio;
                    pontoRepositorio.Add(ponto);
                    pontoRepositorio.Save();

                    return RedirectToAction("Index", new { nomeIdentificador = ponto.NomeIdentificador });
                }
                catch
                {
                    ModelState.AddModelErrors(ponto.GetRuleViolations());
                }
            }

            return View(new PontoFormViewModel(ponto, null));
        }

        public ActionResult Edit(int id)
        {
            Ponto ponto = pontoRepositorio.GetPonto(id);
            ponto.Editando = true;

            if (ponto != null)
                return View(new PontoFormViewModel(ponto, null));
            return View("NaoEncontrado");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Ponto ponto = pontoRepositorio.GetPonto(id);
            if (ModelState.IsValid)
            {

                try
                {

                    if (this.Request.Files.Count > 0)
                    {

                        HttpPostedFileBase file = this.Request.Files[0];
                        Int32 length = file.ContentLength;
                        byte[] logo = new byte[length];
                        file.InputStream.Read(logo, 0, length);
                        ponto.Logo = logo;
                    }

                    if (Session["ImagemLogo"] != null)
                    {
                        ponto.Logo = (byte[])Session["ImagemLogo"];
                    }
                    ponto.Editando = true;
                    ponto.PontoRepositorio = pontoRepositorio;
                    UpdateModel(ponto);
                    pontoRepositorio.Save();

                    return RedirectToAction("Index", new { nomeIdentificador = ponto.NomeIdentificador });
                }
                catch
                {
                    ModelState.AddModelErrors(ponto.GetRuleViolations());
                }
            }

            return View(new PontoFormViewModel(ponto, null));
        }
    }
}
