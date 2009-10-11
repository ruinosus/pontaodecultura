using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.Repositorios;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace PontaoCanavial.Controllers
{
    public class ImageResult : FileStreamResult
    {
        public ImageResult(Image input) : this(input, input.Width, input.Height) { }
        public ImageResult(Image input, int width, int height) :
            base(
              GetMemoryStream(input, width, height, ImageFormat.Png),
              "image/png")
        { }

        static MemoryStream GetMemoryStream(Image input, int width,
                            int height, ImageFormat fmt)
        {
            // maintain aspect ratio 
            if (input.Width > input.Height)
                height = input.Height * width / input.Width;
            else
                width = input.Width * height / input.Height;

            var bmp = new Bitmap(input, width, height);
            var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            ms.Position = 0;
            return ms;
        }
    }

    public class ImageController : Controller
    {
        IPontoRepositorio pontoRepositorio;

        public ImageController()
            : this(new PontoRepositorio())
        {
        }

        public ImageController(IPontoRepositorio repositorio)
        {
            pontoRepositorio = repositorio;
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ThumbImage(int id, int width, int height)
        {
            var ponto = pontoRepositorio.GetPonto(id);
            Image i = null;
            try
            {
                 byte[] tempImage = ponto.Logo.ToArray();
                //Stream. stream = new Stream();



                 i = Image.FromStream(new MemoryStream(tempImage));            
                return new ImageResult(i, width, height);
            }
            catch (Exception ex)
            {
                i = new Bitmap(1, 1);
                return new ImageResult(i, 1, 1);
            }
            finally
            {
                if (i != null) i.Dispose();
            }
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void SaveImage()
        {
            //for (int i = 0; i < Request.Files.Count; i++)
            //{
            //    var file = this.Request.Files[i];
            //    //string savedFileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
            //    //savedFileName = System.IO.Path.Combine(savedFileName, System.IO.Path.GetFileName(file.FileName));
            //    //file.SaveAs(savedFileName);
            //    //Response.Write("OK");
            //    ponto.Logo = new byte[file.ContentLength];
            //    //HttpPostedFileBase arquivo = Request.Files[i].InputStream;

            //    //Suas validações ......

            //    //Salva o arquivo
            //    //if (arquivo.ContentLength > 0)
            //    //{ }
            //}

            HttpPostedFileBase file = this.Request.Files[0];
            Int32 length = file.ContentLength;
            //This may seem odd, but the fun part is that if
            //  I didn't have a temp image to read into, I would
            //  get memory issues for some reason.  Something to do
            //  with reading straight into the object's ActualImage property.
            byte[] tempImage = new byte[length];
            file.InputStream.Read(tempImage, 0, length);
            //newImage.ActualImage = tempImage;

            Session.Add("ImagemLogo", tempImage);
            //ponto.Logo = 
            //ViewData["ImagemLogo"] = new byte[file.ContentLength];
            RedirectToAction("Ponto/Create");
        }


    }
}
