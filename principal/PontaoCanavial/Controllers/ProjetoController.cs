using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloProjeto.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class ProjetoController: Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IProjetoProcesso processo = ProjetoProcesso.Instance;
            Projeto projeto = new Projeto();
            projeto.PontoID = ClasseAuxiliar.PontoID;
            List<Projeto> resultado = processo.Consultar(projeto, TipoPesquisa.E);

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
            Projeto projeto = new Projeto();

            projeto.PontoID = ClasseAuxiliar.PontoID;
            return View(projeto);
        }
        [HttpPost]
        public ActionResult Incluir(Projeto projeto)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                IProjetoProcesso processo = ProjetoProcesso.Instance;
                projeto.PontoID = ClasseAuxiliar.PontoID;

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        projeto.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        projeto.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        projeto.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion
                
                projeto.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;

                processo.Incluir(projeto);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(projeto);
        }
        #endregion


        #region Excluir


        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IProjetoProcesso processo = ProjetoProcesso.Instance;
            Projeto p = new Projeto();
            p.ID = id;
            List<Projeto> resultado = processo.Consultar(p, TipoPesquisa.E);
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

            IProjetoProcesso processo = ProjetoProcesso.Instance;
            Projeto p = new Projeto();
            p.ID = id;
            List<Projeto> resultado = processo.Consultar(p, TipoPesquisa.E);
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

            IProjetoProcesso processo = ProjetoProcesso.Instance;
            Projeto projeto = new Projeto();
            projeto.ID = id;
            List<Projeto> resultado = processo.Consultar(projeto, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");


            projeto = resultado[0];


            if (ModelState.IsValid)
            {
                UpdateModel(projeto);

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        projeto.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        projeto.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        projeto.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion

                processo.Alterar(projeto);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(projeto);
        }
        #endregion
    }
}
