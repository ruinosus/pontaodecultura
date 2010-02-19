using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloImagem.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class ImagemController : Controller
    {

        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IImagemProcesso processo = ImagemProcesso.Instance;
            Imagem imagem = new Imagem();
            imagem.GaleriaID = ClasseAuxiliar.GaleriaID;
            List<Imagem> resultado = processo.Consultar(imagem, TipoPesquisa.E);

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
            Imagem imagem = new Imagem();

            imagem.GaleriaID = ClasseAuxiliar.GaleriaID;
            return View(imagem);
        }
        [HttpPost]
        public ActionResult Incluir(Imagem imagem)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                IImagemProcesso processo = ImagemProcesso.Instance;
                imagem.GaleriaID = ClasseAuxiliar.GaleriaID;

                #region Carregando Imagens

                HttpPostedFileBase imagem0 = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem0.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem0.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        imagem.ImagemPequena = imagemByte;
                    imagem0 = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        imagem.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        imagem.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion

                imagem.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;

                processo.Incluir(imagem);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(imagem);
        }
        #endregion

        #region Excluir


        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IImagemProcesso processo = ImagemProcesso.Instance;
            Imagem i = new Imagem();
            i.ID = id;
            List<Imagem> resultado = processo.Consultar(i, TipoPesquisa.E);
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

            IImagemProcesso processo = ImagemProcesso.Instance;
            Imagem i = new Imagem();
            i.ID = id;
            List<Imagem> resultado = processo.Consultar(i, TipoPesquisa.E);
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

            IImagemProcesso processo = ImagemProcesso.Instance;
            Imagem imagem = new Imagem();
            imagem.ID = id;
            List<Imagem> resultado = processo.Consultar(imagem, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            imagem = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(imagem);

                #region Carregando Imagens

                HttpPostedFileBase imagem0 = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem0.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem0.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        imagem.ImagemPequena = imagemByte;
                    imagem0 = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        imagem.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        imagem.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion

                processo.Alterar(imagem);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(imagem);
        }
        #endregion

    }
}
