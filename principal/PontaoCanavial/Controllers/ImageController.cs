using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using PontaoCanavial.Models.ModuloPonto.Processos;
using PontaoCanavial.Models.ModuloNoticia.Processos;
using PontaoCanavial.Models.ModuloProjeto.Processos;
using PontaoCanavial.Models.ModuloEvento.Processos;
using PontaoCanavial.Models.ModuloProduto.Processos;
using PontaoCanavial.Models.ModuloGaleria.Processos;

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

        [HttpGet]
        public ActionResult ThumbImagePontoCabecalho(int id, int width, int height)
        {
            IPontoProcesso processo = PontoProcesso.Instance;
            Ponto p = new Ponto();
            p.ID = id;
            var ponto = processo.Consultar(p, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
            
            Image i = null;
            try
            {
                byte[] tempCabecalho = ponto[0].Cabecalho.ToArray();
                //Stream. stream = new Stream();



                i = Image.FromStream(new MemoryStream(tempCabecalho));
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

        [HttpGet]
        public ActionResult ThumbImagePontoDetalhe(int id, int width, int height, string tipo)
        {
            IPontoProcesso processo = PontoProcesso.Instance;
            Ponto p = new Ponto();
            p.ID = id;
            var ponto = processo.Consultar(p, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
           
            Image i = null;
            try
            {
                if (tipo.Equals("P") || tipo.Equals("p"))
                {
                    byte[] tempImage = ponto[0].ImagemPequena.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage));

                }
                else if (tipo.Equals("M") || tipo.Equals("m"))
                {
                    byte[] tempImage2 = ponto[0].ImagemMedia.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage2));

                }
                else if (tipo.Equals("G") || tipo.Equals("g"))
                {
                    byte[] tempImage3 = ponto[0].ImagemGrande.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage3));

                }

                //Stream. stream = new Stream();

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

        [HttpGet]
        public ActionResult ThumbImageNoticia(int id, int width, int height, string tipo)
        {
            INoticiaProcesso processo = NoticiaProcesso.Instance;
            Noticia n = new Noticia();
            n.ID = id;
            var noticia = processo.Consultar(n, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
           
            Image i = null;
            try
            {
                if (tipo.Equals("P") || tipo.Equals("p"))
                {
                    byte[] tempImage = noticia[0].ImagemPequena.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage));

                }
                else if (tipo.Equals("M") || tipo.Equals("m"))
                {
                    byte[] tempImage2 = noticia[0].ImagemMedia.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage2));

                }
                else if (tipo.Equals("G") || tipo.Equals("g"))
                {
                    byte[] tempImage3 = noticia[0].ImagemGrande.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage3));

                }

                //Stream. stream = new Stream();

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

        [HttpGet]
        public ActionResult ThumbImageProjeto(int id, int width, int height, string tipo)
        {
            IProjetoProcesso processo = ProjetoProcesso.Instance;
            Projeto p = new Projeto();
            p.ID = id;
            var projeto = processo.Consultar(p, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
           
            Image i = null;
            try
            {
                if (projeto != null)
                {
                    if (tipo.Equals("P") || tipo.Equals("p"))
                    {
                        byte[] tempImage = projeto[0].ImagemPequena.ToArray();

                        i = Image.FromStream(new MemoryStream(tempImage));

                    }
                    else if (tipo.Equals("M") || tipo.Equals("m"))
                    {
                        byte[] tempImage2 = projeto[0].ImagemMedia.ToArray();

                        i = Image.FromStream(new MemoryStream(tempImage2));

                    }
                    else if (tipo.Equals("G") || tipo.Equals("g"))
                    {
                        byte[] tempImage3 = projeto[0].ImagemGrande.ToArray();

                        i = Image.FromStream(new MemoryStream(tempImage3));

                    }
                }
                //Stream. stream = new Stream();

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

        [HttpGet]
        public ActionResult ThumbImageEvento(int id, int width, int height, string tipo)
        {
            IEventoProcesso processo = EventoProcesso.Instance;
            Evento e = new Evento();
            e.ID = id;
            var evento = processo.Consultar(e, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
          
            Image i = null;
            try
            {
                if (tipo.Equals("P") || tipo.Equals("p"))
                {
                    byte[] tempImage = evento[0].ImagemPequena.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage));

                }
                else if (tipo.Equals("M") || tipo.Equals("m"))
                {
                    byte[] tempImage2 = evento[0].ImagemMedia.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage2));

                }
                else if (tipo.Equals("G") || tipo.Equals("g"))
                {
                    byte[] tempImage3 = evento[0].ImagemGrande.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage3));

                }

                //Stream. stream = new Stream();

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

        [HttpGet]
        public ActionResult ThumbImageProduto(int id, int width, int height, string tipo)
        {
            IProdutoProcesso processo = ProdutoProcesso.Instance;
            Produto p = new Produto();
            p.ID = id;
            var produto = processo.Consultar(p, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
          
            Image i = null;
            try
            {
                if (tipo.Equals("P") || tipo.Equals("p"))
                {
                    byte[] tempImage = produto[0].ImagemPequena.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage));

                }
                else if (tipo.Equals("M") || tipo.Equals("m"))
                {
                    byte[] tempImage2 = produto[0].ImagemMedia.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage2));

                }
                else if (tipo.Equals("G") || tipo.Equals("g"))
                {
                    byte[] tempImage3 = produto[0].ImagemGrande.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage3));

                }

                //Stream. stream = new Stream();

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

        [HttpGet]
        public ActionResult ThumbImageGaleria(int id, int width, int height, string tipo)
        {
            IGaleriaProcesso processo = GaleriaProcesso.Instance;
            Galeria g = new Galeria();
            g.ID = id;
            var galeria = processo.Consultar(g, PontaoCanavial.Models.ModuloBasico.Enums.TipoPesquisa.E);
          
            Image i = null;
            try
            {
                if (tipo.Equals("P") || tipo.Equals("p"))
                {
                    byte[] tempImage = galeria[0].ImagemPequena.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage));

                }
                else if (tipo.Equals("M") || tipo.Equals("m"))
                {
                    byte[] tempImage2 = galeria[0].ImagemMedia.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage2));

                }
                else if (tipo.Equals("G") || tipo.Equals("g"))
                {
                    byte[] tempImage3 = galeria[0].ImagemGrande.ToArray();

                    i = Image.FromStream(new MemoryStream(tempImage3));

                }

                //Stream. stream = new Stream();

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

    }
}
