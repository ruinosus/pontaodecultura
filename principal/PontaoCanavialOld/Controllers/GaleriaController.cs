using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using PontaoCanavial.Models.Repositorios;
using PontaoCanavial.Models.VOs;
using PontaoCanavialOld.Helpers;
using System.IO;
using PontaoCanavial.Models.Repositorios.Interfaces;

namespace PontaoCanavial.Controllers
{
    [HandleError]
    public class GaleriaController : Controller
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

        IGaleriaRepositorio galeriaRepositorio;

        public GaleriaController()
            : this(new GaleriaRepositorio())
        {
        }

        public GaleriaController(IGaleriaRepositorio repositorio)
        {
            galeriaRepositorio = repositorio;
        }

        public ActionResult Index()
        {
            return View();

        }

        public ActionResult GaleriaDetalhe(int id)
        {
            return View();
        }

        public ActionResult Create(int id)
        {
            Galeria galeria = new Galeria();
            Session.Add("PontoId", id);
            galeria.PontoId = id;
            return View(galeria);
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
        public ActionResult Create(Galeria g)
        {
  
            if (ModelState.IsValid)
            {

                try
                {
                    g.PontoId = Convert.ToInt32(Session["PontoId"].ToString());

                    HttpPostedFileBase imagem = this.Request.Files.Get("imgPequena");
                    if (imagem!=null)
                    {

                        Int32 length = imagem.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        g.ImagemPequena= imagemByte;
                    }

                    HttpPostedFileBase imagem2 = this.Request.Files.Get("imgMedia");
                    if (imagem2 != null)
                    {

                        Int32 length = imagem2.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem2.InputStream.Read(imagemByte, 0, length);
                        g.ImagemMedia = imagemByte;
                    }

                    HttpPostedFileBase imagem3 = this.Request.Files.Get("imgGrande");
                    if (imagem3 != null)
                    {
                        Int32 length = imagem3.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem3.InputStream.Read(imagemByte, 0, length);
                        g.ImagemGrande = imagemByte;
                    }

                    galeriaRepositorio.Add(g);
                    galeriaRepositorio.Save();

                    return RedirectToAction("../Galeria/Index");
                }
                catch(Exception e)
                {
                    ModelState.AddModelErrors(g.GetRuleViolations());
                    ModelState.AddModelError("erro", e.Message);
                }
            }

            return View(g);
        }

        public ActionResult Edit(int id)
        {
            Galeria g = galeriaRepositorio.GetGaleria(id);

            if (g != null)
                return View(g);
            return View("NaoEncontrado");
        }

    }
}
