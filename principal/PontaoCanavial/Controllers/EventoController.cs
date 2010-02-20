using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloEvento.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class EventoController: Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IEventoProcesso processo = EventoProcesso.Instance;
            Evento evento = new Evento();
            evento.PontoID = ClasseAuxiliar.PontoID;
            List<Evento> resultado = processo.Consultar(evento, TipoPesquisa.E);

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
            Evento evento = new Evento();

            evento.PontoID = ClasseAuxiliar.PontoID;
            return View(evento);
        }
        [HttpPost]
        public ActionResult Incluir(Evento evento)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                IEventoProcesso processo = EventoProcesso.Instance;
                evento.PontoID = ClasseAuxiliar.PontoID;

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        evento.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        evento.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        evento.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion                
                evento.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;

                processo.Incluir(evento);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(evento);
        }
        #endregion

        #region Excluir
        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IEventoProcesso processo = EventoProcesso.Instance;
            Evento ev = new Evento();
            ev.ID = id;
            List<Evento> resultado = processo.Consultar(ev, TipoPesquisa.E);
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

            IEventoProcesso processo = EventoProcesso.Instance;
            Evento ev = new Evento();
            ev.ID = id;
            List<Evento> resultado = processo.Consultar(ev, TipoPesquisa.E);
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

            IEventoProcesso processo = EventoProcesso.Instance;
            Evento evento = new Evento();
            evento.ID = id;
            List<Evento> resultado = processo.Consultar(evento, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            evento = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(evento);

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        evento.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        evento.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        evento.ImagemGrande = imagemByte;
                    imagem3 = null;
                }

                #endregion

                processo.Alterar(evento);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(evento);
        }
        #endregion
    }
}
