using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloUsuarioPonto.Processos;
using PontaoCanavial.Models.ModuloBasico.Enums;

namespace PontaoCanavial.Controllers
{
    public class PainelAdministradorController : Controller
    {
        public ActionResult ListaPonto()
        {
            if (ClasseAuxiliar.UsuarioLogado == null)
                return Redirect("/Usuario/Logar");

            IUsuarioPontoProcesso processo = UsuarioPontoProcesso.Instance;

            UsuarioPonto usuarioPonto = new UsuarioPonto();
            usuarioPonto.UsuarioID = ClasseAuxiliar.UsuarioLogado.ID;

            List<UsuarioPonto> resultado = processo.Consultar(usuarioPonto, TipoPesquisa.E);

            Session.Add("UsuarioPontoLogadoLista", resultado);
            return View(resultado);

        }

    }
}
