<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Models.VOs" %>

    <%if (Model.Ponto == null)
      {
          Response.Redirect("NaoEncontrado", false);
      }      
    %>
   <b>
    <%=
        Html.Encode(Model.Ponto.Nome)
    %></b>
   <br />
    <%
    if (Model.Ponto.EPontao.HasValue)
        if (Model.Ponto.EPontao.Value)
            foreach (Ponto ponto in Model.Pontinhos)
            {
    %>
    <%=     Html.ActionLink(ponto.Nome, "Index", new { nomeIdentificador = ponto.NomeIdentificador})%>
    <br />
    <%
            }
    %>
