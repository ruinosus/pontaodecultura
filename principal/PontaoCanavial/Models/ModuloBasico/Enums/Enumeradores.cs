using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;

namespace PontaoCanavial.Models.ModuloBasico.Enums
{
    public enum TipoPesquisa
    {
        E = 0,
        Ou = 1
    }

    public enum Status
    {
        Pontinho = 0,
        Pontao = 1
    }

    

    public enum OperacoesDaTela
    {
        Incluindo = 1,
        Alterando = 2,
        Excluindo = 3,
        Navegando = 6,
        Bloquear = 7,
        Inativa= 8
    }

    

}
