using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using PontaoCanavial.Models.ModuloPonto.Processos;

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

        public ImageController()
        {

        }



        [HttpGet]
        public ActionResult ThumbImagePonto(int id, int width, int height)
        {
            IPontoProcesso processo = PontoProcesso.Instance;
            Ponto p = new Ponto();
            p.ID = id;
            var ponto = processo.Consultar(p,PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
            
            Image i = null;
            try
            {
                byte[] tempLogo = ponto[0].Logo.ToArray();
                //Stream. stream = new Stream();

                i = Image.FromStream(new MemoryStream(tempLogo));
                return new ImageResult(i, width, height);
            }
            catch (Exception)
            {
                i = new Bitmap(1, 1);
                return new ImageResult(i, 1, 1);
            }
            finally
            {
                if (i != null) i.Dispose();
            }
        }

        //[HttpGet]
        //public ActionResult ThumbImagePontoCabecalho(int id, int width, int height)
        //{
        //    var ponto = pontoRepositorio.GetPonto(id);
        //    Image i = null;
        //    try
        //    {
        //        byte[] tempCabecalho = ponto.Cabecalho.ToArray();
        //        //Stream. stream = new Stream();



        //        i = Image.FromStream(new MemoryStream(tempCabecalho));
        //        return new ImageResult(i, width, height);
        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

        //[HttpGet]
        //public ActionResult ThumbImagePontoDetalhe(int id, int width, int height, string tipo)
        //{
        //    var ponto = pontoRepositorio.GetPonto(id);
        //    Image i = null;
        //    try
        //    {
        //        if (tipo.Equals("P") || tipo.Equals("p"))
        //        {
        //            byte[] tempImage = ponto.ImagemPequena.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage));

        //        }
        //        else if (tipo.Equals("M") || tipo.Equals("m"))
        //        {
        //            byte[] tempImage2 = ponto.ImagemMedia.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage2));

        //        }
        //        else if (tipo.Equals("G") || tipo.Equals("g"))
        //        {
        //            byte[] tempImage3 = ponto.ImagemGrande.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage3));

        //        }

        //        //Stream. stream = new Stream();

        //        return new ImageResult(i, width, height);

        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

        //[HttpGet]
        //public ActionResult ThumbImageNoticia(int id, int width, int height, string tipo)
        //{
        //    var noticia = noticiaRepositorio.GetNoticia(id);
        //    Image i = null;
        //    try
        //    {
        //        if (tipo.Equals("P") || tipo.Equals("p"))
        //        {
        //            byte[] tempImage = noticia.ImagemPequena.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage));

        //        }
        //        else if (tipo.Equals("M") || tipo.Equals("m"))
        //        {
        //            byte[] tempImage2 = noticia.ImagemMedia.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage2));

        //        }
        //        else if (tipo.Equals("G") || tipo.Equals("g"))
        //        {
        //            byte[] tempImage3 = noticia.ImagemGrande.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage3));

        //        }

        //        //Stream. stream = new Stream();

        //        return new ImageResult(i, width, height);

        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

        //[HttpGet]
        //public ActionResult ThumbImageProjeto(int id, int width, int height, string tipo)
        //{
        //    var projeto = projetoRepositorio.GetProjeto(4);
        //    Image i = null;
        //    try
        //    {
        //        if (projeto != null)
        //        {
        //            if (tipo.Equals("P") || tipo.Equals("p"))
        //            {
        //                byte[] tempImage = projeto.ImagemPequena.ToArray();

        //                i = Image.FromStream(new MemoryStream(tempImage));

        //            }
        //            else if (tipo.Equals("M") || tipo.Equals("m"))
        //            {
        //                byte[] tempImage2 = projeto.ImagemMedia.ToArray();

        //                i = Image.FromStream(new MemoryStream(tempImage2));

        //            }
        //            else if (tipo.Equals("G") || tipo.Equals("g"))
        //            {
        //                byte[] tempImage3 = projeto.ImagemGrande.ToArray();

        //                i = Image.FromStream(new MemoryStream(tempImage3));

        //            }
        //        }
        //        //Stream. stream = new Stream();

        //        return new ImageResult(i, width, height);

        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

        //[HttpGet]
        //public ActionResult ThumbImageEvento(int id, int width, int height, string tipo)
        //{
        //    var evento = eventoRepositorio.GetEvento(id);
        //    Image i = null;
        //    try
        //    {
        //        if (tipo.Equals("P") || tipo.Equals("p"))
        //        {
        //            byte[] tempImage = evento.ImagemPequena.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage));

        //        }
        //        else if (tipo.Equals("M") || tipo.Equals("m"))
        //        {
        //            byte[] tempImage2 = evento.ImagemMedia.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage2));

        //        }
        //        else if (tipo.Equals("G") || tipo.Equals("g"))
        //        {
        //            byte[] tempImage3 = evento.ImagemGrande.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage3));

        //        }

        //        //Stream. stream = new Stream();

        //        return new ImageResult(i, width, height);

        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

        //[HttpGet]
        //public ActionResult ThumbImageProduto(int id, int width, int height, string tipo)
        //{
        //    var produto = produtoRepositorio.GetProduto(id);
        //    Image i = null;
        //    try
        //    {
        //        if (tipo.Equals("P") || tipo.Equals("p"))
        //        {
        //            byte[] tempImage = produto.ImagemPequena.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage));

        //        }
        //        else if (tipo.Equals("M") || tipo.Equals("m"))
        //        {
        //            byte[] tempImage2 = produto.ImagemMedia.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage2));

        //        }
        //        else if (tipo.Equals("G") || tipo.Equals("g"))
        //        {
        //            byte[] tempImage3 = produto.ImagemGrande.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage3));

        //        }

        //        //Stream. stream = new Stream();

        //        return new ImageResult(i, width, height);

        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

        //[HttpGet]
        //public ActionResult ThumbImageGaleria(int id, int width, int height, string tipo)
        //{
        //    var galeria = galeriaRepositorio.GetGaleria(id);
        //    Image i = null;
        //    try
        //    {
        //        if (tipo.Equals("P") || tipo.Equals("p"))
        //        {
        //            byte[] tempImage = galeria.ImagemPequena.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage));

        //        }
        //        else if (tipo.Equals("M") || tipo.Equals("m"))
        //        {
        //            byte[] tempImage2 = galeria.ImagemMedia.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage2));

        //        }
        //        else if (tipo.Equals("G") || tipo.Equals("g"))
        //        {
        //            byte[] tempImage3 = galeria.ImagemGrande.ToArray();

        //            i = Image.FromStream(new MemoryStream(tempImage3));

        //        }

        //        //Stream. stream = new Stream();

        //        return new ImageResult(i, width, height);

        //    }
        //    catch (Exception ex)
        //    {
        //        i = new Bitmap(1, 1);
        //        return new ImageResult(i, 1, 1);
        //    }
        //    finally
        //    {
        //        if (i != null) i.Dispose();
        //    }
        //}

    }
}
