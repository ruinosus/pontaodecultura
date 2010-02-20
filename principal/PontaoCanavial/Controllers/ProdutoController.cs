using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloProduto.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;
using PontaoCanavial.Models.ModuloBasico.VOs;

namespace PontaoCanavial.Controllers
{
    public class ProdutoController: Controller
    {
        public ActionResult Listar()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IProdutoProcesso processo = ProdutoProcesso.Instance;
            Produto produto = new Produto();
            produto.PontoID = ClasseAuxiliar.PontoID;
            List<Produto> resultado = processo.Consultar(produto, TipoPesquisa.E);

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
            Produto produto = new Produto();

            produto.PontoID = ClasseAuxiliar.PontoID;
            return View(produto);
        }
        [HttpPost]
        public ActionResult Incluir(Produto produto)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");
            if (ModelState.IsValid)
            {
                IProdutoProcesso processo = ProdutoProcesso.Instance;
                produto.PontoID = ClasseAuxiliar.PontoID;

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        produto.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        produto.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        produto.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion
                produto.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;

                processo.Incluir(produto);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }
            //Invalido - volta a tela mostrando os erros contidos.
            return View(produto);
        }
        #endregion

        #region Excluir


        [HttpGet]
        public ActionResult Excluir(int id)
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IProdutoProcesso processo = ProdutoProcesso.Instance;
            Produto p = new Produto();
            p.ID = id;
            List<Produto> resultado = processo.Consultar(p, TipoPesquisa.E);
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

            IProdutoProcesso processo = ProdutoProcesso.Instance;
            Produto p = new Produto();
            p.ID = id;
            List<Produto> resultado = processo.Consultar(p, TipoPesquisa.E);
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

            IProdutoProcesso processo = ProdutoProcesso.Instance;
            Produto produto = new Produto();
            produto.ID = id;
            List<Produto> resultado = processo.Consultar(produto, TipoPesquisa.E);

            if (resultado == null && resultado.Count != 1)
                return View("NaoEncontrado");

            produto = resultado[0];

            if (ModelState.IsValid)
            {
                UpdateModel(produto);

                #region Carregando Imagens

                HttpPostedFileBase imagem = this.Request.Files.Get("imgpequena");
                if (imagem != null)
                {

                    Int32 length = imagem.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        produto.ImagemPequena = imagemByte;
                    imagem = null;
                }

                HttpPostedFileBase imagem2 = this.Request.Files.Get("imgmedia");
                if (imagem2 != null)
                {

                    Int32 length = imagem2.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem2.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        produto.ImagemMedia = imagemByte;
                    imagem2 = null;
                }

                HttpPostedFileBase imagem3 = this.Request.Files.Get("imggrande");
                if (imagem3 != null)
                {
                    Int32 length = imagem3.ContentLength;
                    byte[] imagemByte = new byte[length];
                    imagem3.InputStream.Read(imagemByte, 0, length);
                    if (imagemByte.Count() > 0)
                        produto.ImagemGrande = imagemByte;
                    imagem3 = null;
                }


                #endregion

                processo.Alterar(produto);
                processo.Confirmar();
                return RedirectToAction("Listar");
            }

            return View(produto);
        }
        #endregion
    }
}
