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
    public class NoticiaController : Controller
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

        INoticiaRepositorio noticiaRepositorio;

        public NoticiaController()
            : this(new NoticiaRepositorio())
        {
        }

        public NoticiaController(INoticiaRepositorio repositorio)
        {
            noticiaRepositorio = repositorio;
        }

        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create(int id)
        {
            Noticia noticia = new Noticia();
            noticia.PontoId = id;
            return View(noticia);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Noticia noticia)
        {
  
            if (ModelState.IsValid)
            {

                try
                {

                    HttpPostedFileBase imagem = this.Request.Files.Get("imgImagem");
                    if (imagem!=null)
                    {

                        Int32 length = imagem.ContentLength;
                        byte[] imagemByte = new byte[length];
                        imagem.InputStream.Read(imagemByte, 0, length);
                        noticia.Imagem= imagemByte;
                    }

                    noticiaRepositorio.Add(noticia);
                    noticiaRepositorio.Save();

                    return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelErrors(noticia.GetRuleViolations());
                   // ModelState.AddModelError("erro", "erro no banco");
                }
            }

            return View(noticia);
        }

        public ActionResult Edit(int id)
        {
            Noticia noticia = noticiaRepositorio.GetNoticia(id);

            if (noticia != null)
                return View(noticia);
            return View("NaoEncontrado");
        }

    }

}

