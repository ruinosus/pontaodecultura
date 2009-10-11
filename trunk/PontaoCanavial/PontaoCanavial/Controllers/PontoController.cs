using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using PontaoCanavial.Models.Repositorios.Interfaces;
using PontaoCanavial.Models.Repositorios;
using PontaoCanavial.Models.VOs;
using PontaoCanavial.Helpers;
using System.IO;

namespace PontaoCanavial.Controllers
{

    #region ViewModel Classes
   
    public class PontoFormViewModel
    {
        #region Propriedades

        public Ponto Ponto { get; private set; }
        public List<Ponto> Pontinhos { get; private set; }

        #endregion

        #region Construtores

        public PontoFormViewModel(Ponto ponto, List<Ponto> pontinhos)
        {
            Ponto = ponto;
            Pontinhos = pontinhos;
        }
        #endregion
    } 
    #endregion

    [HandleError]
    public class PontoController : Controller
    {

        private byte [] ConverterByte(string filename){  
            FileStream fs = new FileStream(filename, FileMode.Open,FileAccess.Read);  
            // Create a byte array of file stream length  
            byte[] ImageData = new byte[fs.Length];  
            //Read block of bytes from stream into the byte array   
            fs.Read(ImageData,0,System.Convert.ToInt32(fs.Length)); 
            //Close the File Stream  
            fs.Close();  
            return ImageData; 
            //return the byte data
        }

        IPontoRepositorio pontoRepositorio;

        public PontoController()
            : this(new PontoRepositorio())
        {
        }

        public PontoController(IPontoRepositorio repositorio)
        {
            pontoRepositorio = repositorio;
        }
        //
        // GET: /Ponto/

        public ActionResult Index(string nomeIdentificador)
        {
            if (!string.IsNullOrEmpty(nomeIdentificador))
            {
                var pontinho = pontoRepositorio.ConsultarPorNomeIdentificador(nomeIdentificador);
                if (pontinho != null && pontinho.NomeIdentificador != string.Empty)
                    return View(new PontoFormViewModel(pontinho,null));
                else
                    return View("NaoEncontrado");
            }
            else
            {
                var pontao = pontoRepositorio.ConsultarPontao();
                List<Ponto> pontinhos = pontoRepositorio.ConsultarTodos(true).ToList();
                return View(new PontoFormViewModel(pontao, pontinhos));

            }

        }

        //
        // GET: /Ponto/Details/5

        public ActionResult Details(int id)
        {
            
            return View();
        }      

        //
        // GET: /Ponto/Create

        
        public ActionResult Create()
        {
            Ponto ponto = new Ponto();
            return View(new PontoFormViewModel(ponto, null));
        }

        //
        // POST: /Ponto/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Ponto ponto, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid) {

                try {

                    HttpPostedFileBase file = this.Request.Files[0];
                    Int32 length = file.ContentLength;
                    byte[] logo = new byte[length];
                    file.InputStream.Read(logo, 0, length);
                    ponto.Logo = logo;
                    if (Session["ImagemLogo"] != null)
                    {
                        ponto.Logo = (byte[])Session["ImagemLogo"];

                    } 
                    ponto.PontoRepositorio = pontoRepositorio;
                    pontoRepositorio.Add(ponto);
                    pontoRepositorio.Save();

                    return RedirectToAction("Index", new { nomeIdentificador=ponto.NomeIdentificador});
                }
                catch {
                    ModelState.AddModelErrors(ponto.GetRuleViolations());
                }
            }

            return View(new PontoFormViewModel(ponto,null));
        }

        //
        // GET: /Ponto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ponto/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
