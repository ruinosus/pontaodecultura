using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.IO;
using PontaoCanavial.Models.Repositorios;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.VOs;
using PontaoCanavialOld.Helpers;

namespace PontaoCanavial.Controllers
{
    [HandleError]
    public class ProdutoController : Controller
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

        IProdutoRepositorio produtoRepositorio;

        public ProdutoController()
            : this(new ProdutoRepositorio())
        {
        }

        public ProdutoController(IProdutoRepositorio repositorio)
        {
            produtoRepositorio = repositorio;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProdutoDetalhe(int id)
        {
            return View();
        }

        public ActionResult Create(int id)
        {
            Produto p = new Produto();
            Session.Add("PontoId", id);
            p.PontoId = id;
            return View(p);
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        //if (fupImgPostagem.HasFile)
        //    {
        //        HttpPostedFile myFile = fupImgPostagem.PostedFile;

        //        System.Drawing.Image fullSizeImg = System.Drawing.Image.FromStream(myFile.InputStream);

        //        System.Drawing.Image.GetThumbnailImageAbort dummyCallBack = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

        //        System.Drawing.Image thumbNailImg = fullSizeImg.GetThumbnailImage(200, 200, dummyCallBack, IntPtr.Zero);

        //        postagem.Imagem = ClasseAuxiliar.imageToByteArray(thumbNailImg);
        //    }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Produto produto)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    produto.PontoId = Convert.ToInt32(Session["PontoId"].ToString());

                    HttpPostedFileBase imagem = this.Request.Files.Get("imgPequena");
                    if (imagem != null)
                    {

                        Int32 length = imagem.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        produto.ImagemPequena = imagemByte;
                    }

                    HttpPostedFileBase imagem2 = this.Request.Files.Get("imgMedia");
                    if (imagem2 != null)
                    {

                        Int32 length = imagem2.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem2.InputStream.Read(imagemByte, 0, length);
                        produto.ImagemMedia = imagemByte;
                    }

                    HttpPostedFileBase imagem3 = this.Request.Files.Get("imgGrande");
                    if (imagem3 != null)
                    {
                        Int32 length = imagem3.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem3.InputStream.Read(imagemByte, 0, length);
                        produto.ImagemGrande = imagemByte;
                    }

                    produtoRepositorio.Add(produto);
                    produtoRepositorio.Save();

                    return RedirectToAction("../Produto/Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelErrors(produto.GetRuleViolations());
                    ModelState.AddModelError("erro", e.Message);
                }
            }

            return View(produto);
        }

        public ActionResult Edit(int id)
        {
            Produto p = produtoRepositorio.GetProduto(id);

            if (p != null)
                return View(p);
            return View("NaoEncontrado");
        }

    }
}
