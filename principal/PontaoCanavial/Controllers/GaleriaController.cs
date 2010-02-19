using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloGaleria.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class GaleriaController : Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IGaleriaProcesso processo = GaleriaProcesso.Instance;
            Galeria galeria = new Galeria();
            galeria.PontoID = ClasseAuxiliar.PontoID;
            List<Galeria> resultado = processo.Consultar(galeria, TipoPesquisa.E);

            if (resultado != null)
                return View(resultado);
            else
                return View("NaoEncontrado");


        }

        [HttpGet]
        public ActionResult SelecionarGaleria(int id)
        {
            Session.Add("GaleriaID", id);
            return Redirect("/Imagem/Listar");
        }

        #region Incluir
        public ActionResult Incluir()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            Galeria galeria = new Galeria();

            galeria.PontoID = ClasseAuxiliar.PontoID;
            return View(galeria);
        }
        [HttpPost]
        public ActionResult Incluir(Galeria galeria)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                IGaleriaProcesso processo = GaleriaProcesso.Instance;
                galeria.PontoID = ClasseAuxiliar.PontoID;

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        galeria.ImagemPequena = imagemByte;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        galeria.ImagemMedia = imagemByte;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        galeria.ImagemGrande = imagemByte;
                }


                #endregion

                galeria.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;

                processo.Incluir(galeria);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(galeria);
        }
        #endregion

        #region Excluir


        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IGaleriaProcesso processo = GaleriaProcesso.Instance;
            Galeria g = new Galeria();
            g.ID = id;
            List<Galeria> resultado = processo.Consultar(g, TipoPesquisa.E);
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

            IGaleriaProcesso processo = GaleriaProcesso.Instance;
            Galeria g = new Galeria();
            g.ID = id;
            List<Galeria> resultado = processo.Consultar(g, TipoPesquisa.E);
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

            IGaleriaProcesso processo = GaleriaProcesso.Instance;
            Galeria galeria = new Galeria();
            galeria.ID = id;
            List<Galeria> resultado = processo.Consultar(galeria, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            galeria = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(galeria);

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        galeria.ImagemPequena = imagemByte;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        galeria.ImagemMedia = imagemByte;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        galeria.ImagemGrande = imagemByte;
                }


                #endregion

                processo.Alterar(galeria);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(galeria);
        }
        #endregion
    }
}
