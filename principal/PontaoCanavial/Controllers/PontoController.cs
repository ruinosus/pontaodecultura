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
using PontaoCanavial.Models.ModuloNoticia.Processos;
using PontaoCanavial.Models.ModuloProjeto.Processos;
using PontaoCanavial.Models.ModuloEvento.Processos;

namespace PontaoCanavial.Controllers
{
    public class PontoController : Controller
    {
        #region Ponto
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

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        ponto.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        ponto.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        ponto.ImagemGrande = imagemByte;
                    imagem3 = null;
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

        #region Alterar

        public ActionResult Alterar(int id)
        {


            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            if (!ClasseAuxiliar.VerificarUsuarioPonto(id))
                return View("NaoEncontrado");

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
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            if (!ClasseAuxiliar.VerificarUsuarioPonto(id))
                return View("NaoEncontrado");
            IPontoProcesso processo = PontoProcesso.Instance;
            Ponto ponto = new Ponto();
            ponto.ID = id;
            List<Ponto> resultado = processo.Consultar(ponto, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            ponto = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(ponto);

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        ponto.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        ponto.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        ponto.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion

                processo.Alterar(ponto);
                processo.Confirmar();
                return RedirectToAction("Index", new { nomeIdentificador = ponto.NomeIdentificador });
            }

            return View(ponto);
        }
        #endregion
        #endregion
        
        #region Detalhes Pontão
        public ActionResult NoticiaLista()
        {
            return View("NoticiaLista", ClasseAuxiliar.PontoFormViewModel);
        }

        public ActionResult BuscaLista(string valor, int? id)
        {
            PontoFormViewModel pfvm = (PontoFormViewModel)Session["PontoFormViewModel"];
            //pfvm = pontoRepositorio.Buscar(pfvm, valor, 1);
            Session["PontoFormViewModel"] = pfvm;
            return View("BuscaLista", pfvm);
        }

        public ActionResult ProjetoLista()
        {
            return View("ProjetoLista", ClasseAuxiliar.PontoFormViewModel);
        }

        public ActionResult EventoLista()
        {
            return View("EventoLista", ClasseAuxiliar.PontoFormViewModel);
        }

        public ActionResult ProdutoLista()
        {
            return View("ProdutoLista", ClasseAuxiliar.PontoFormViewModel);
        }

        public ActionResult PontoDetalhe()
        {
            return View("PontoDetalhe", ClasseAuxiliar.PontoFormViewModel);
        }

        public ActionResult ProjetoDetalhe(int id)
        {

            IProjetoProcesso processo = ProjetoProcesso.Instance;

            Projeto p = new Projeto();
            p.ID = id;

            List<Projeto> resultado = processo.Consultar(p, TipoPesquisa.E);


            if (resultado != null && resultado.Count == 1)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.ProjetoDetalhe = resultado[0];
                return View("ProjetoDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        public ActionResult NoticiaDetalhe(int id)
        {

            Noticia n = new Noticia();
            n.ID = id;
            INoticiaProcesso processo = NoticiaProcesso.Instance;
            List<Noticia> resultado = processo.Consultar(n, TipoPesquisa.E);
            if (resultado!=null && resultado.Count == 1)
            {
                PontoFormViewModel pfvm = ClasseAuxiliar.PontoFormViewModel;
                pfvm.NoticiaDetalhe = resultado[0];
                return View("NoticiaDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        public ActionResult EventoDetalhe(int id)
        {

            IEventoProcesso processo = EventoProcesso.Instance;

            Evento e = new Evento();
            e.ID = id;

            List<Evento> resultado = processo.Consultar(e, TipoPesquisa.E);


            if (resultado != null && resultado.Count == 1)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.EventoDetalhe = resultado[0];
                return View("EventoDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        #endregion

        #region Detalhes Pontinho

        //pontinho
        public ActionResult PontinhoNoticiaLista()
        {
            PontoFormViewModel p = (PontoFormViewModel)Session["PontoFormViewModel"];

            return View("PontinhoNoticiaLista", p);
        }

        //pontinho
        public ActionResult PontinhoProjetoLista()
        {
            return View("PontinhoProjetoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //Pontinho
        public ActionResult PontinhoEventoDetalhe(int id)
        {
            IEventoProcesso processo = EventoProcesso.Instance;

            Evento e = new Evento();
            e.ID = id;

            List<Evento> resultado = processo.Consultar(e, TipoPesquisa.E);


            if (resultado != null && resultado.Count == 1)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.EventoDetalhe= resultado[0];
                return View("PontinhoEventoDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        //pontinho
        public ActionResult PontinhoNoticiaDetalhe(int id)
        {
            INoticiaProcesso processo = NoticiaProcesso.Instance;

            Noticia n = new Noticia();
            n.ID = id;

            List<Noticia> resultado = processo.Consultar(n,TipoPesquisa.E);

            if (resultado != null && resultado.Count==1)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.NoticiaDetalhe = resultado[0];
                return View("PontinhoNoticiaDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        //pontinho
        public ActionResult PontinhoProdutoLista()
        {
            return View("PontinhoProdutoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //pontinho
        public ActionResult PontinhoProjetoDetalhe(int id)
        {

            IProjetoProcesso processo = ProjetoProcesso.Instance;

            Projeto p = new Projeto();
            p.ID = id;

            List<Projeto> resultado = processo.Consultar(p, TipoPesquisa.E);

            if (resultado != null && resultado.Count == 1)
            {
                PontoFormViewModel pfvm = ((PontoFormViewModel)Session["PontoFormViewModel"]);
                pfvm.ProjetoDetalhe = resultado[0];
                return View("PontinhoProjetoDetalhe", pfvm);
            }
            return View("NaoEncontrado");
        }

        //pontinho
        public ActionResult PontinhoEventoLista()
        {
            return View("PontinhoEventoLista", (PontoFormViewModel)Session["PontoFormViewModel"]);
        }

        //pontinho
        public ActionResult PontinhoDetalhe()
        {
            return View("PontinhoDetalhe", (PontoFormViewModel)Session["PontoFormViewModel"]);
        } 
        #endregion        
        
    }
}
