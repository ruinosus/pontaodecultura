using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.IO;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.Repositorios;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Helpers;

namespace PontaoCanavial.Controllers
{
    [HandleError]
    public class ProjetoController : Controller
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

        IProjetoRepositorio projetoRepositorio;

        public ProjetoController()
            : this(new ProjetoRepositorio())
        {
        }

        public ProjetoController(IProjetoRepositorio repositorio)
        {
            projetoRepositorio = repositorio;
        }

        public ActionResult Index()
        {
            return View();

        }

        public ActionResult ProjetoDetalhe(int id)
        {
            return View();
        }

        public ActionResult Create(int id)
        {
            Projeto p = new Projeto();
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
        public ActionResult Create(Projeto p)
        {
  
            if (ModelState.IsValid)
            {

                try
                {
                    p.PontoId = Convert.ToInt32(Session["PontoId"].ToString());

                    HttpPostedFileBase imagem = this.Request.Files.Get("imgImagemPequena");
                    if (imagem!=null)
                    {

                        Int32 length = imagem.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        p.ImagemPequena= imagemByte;
                    }

                    HttpPostedFileBase imagem2 = this.Request.Files.Get("imgImagemMedia");
                    if (imagem != null)
                    {

                        Int32 length = imagem2.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        p.ImagemMedia = imagemByte;
                    }

                    HttpPostedFileBase imagem3 = this.Request.Files.Get("imgImagemGrande");
                    if (imagem != null)
                    {
                        Int32 length = imagem3.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        p.ImagemGrande = imagemByte;
                    }

                    projetoRepositorio.Add(p);
                    projetoRepositorio.Save();

                    return RedirectToAction("../Projeto/Index");
                }
                catch(Exception e)
                {
                    ModelState.AddModelErrors(p.GetRuleViolations());
                    ModelState.AddModelError("erro", e.Message);
                }
            }

            return View(p);
        }

        public ActionResult Edit(int id)
        {
            Projeto p = projetoRepositorio.GetProjeto(id);

            if (p != null)
                return View(p);
            return View("NaoEncontrado");
        }

    }

}

