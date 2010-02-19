using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloNoticia.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class NoticiaController : Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            INoticiaProcesso processo = NoticiaProcesso.Instance;
            Noticia noticia = new Noticia();
            noticia.PontoID = ClasseAuxiliar.PontoID;
            List<Noticia> resultado = processo.Consultar(noticia, TipoPesquisa.E);

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
            Noticia noticia = new Noticia();

            noticia.PontoID = ClasseAuxiliar.PontoID;
            return View(noticia);
        }
        [HttpPost]
        public ActionResult Incluir(Noticia noticia)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                INoticiaProcesso processo = NoticiaProcesso.Instance;
                noticia.PontoID = ClasseAuxiliar.PontoID;

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        noticia.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        noticia.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        noticia.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion
                noticia.DataCriacao = DateTime.Now;
                noticia.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;
                
                processo.Incluir(noticia);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(noticia);
        } 
        #endregion

        #region Excluir

      
        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            INoticiaProcesso processo = NoticiaProcesso.Instance;
            Noticia n = new Noticia();
            n.ID = id;
            List<Noticia> resultado = processo.Consultar(n, TipoPesquisa.E);
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

            INoticiaProcesso processo = NoticiaProcesso.Instance;
            Noticia n = new Noticia();
            n.ID = id;
            List<Noticia> resultado = processo.Consultar(n, TipoPesquisa.E);
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

            INoticiaProcesso processo = NoticiaProcesso.Instance;
            Noticia noticia = new Noticia();
            noticia.ID = id;
            List<Noticia> resultado = processo.Consultar(noticia, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            noticia = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(noticia);

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        noticia.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        noticia.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        noticia.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion

                processo.Alterar(noticia);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(noticia);
        } 
        #endregion
    }
}
