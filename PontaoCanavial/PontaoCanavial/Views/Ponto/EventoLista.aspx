<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="eventos-list">
            <h1>
                <img src="../../App_Themes/Pontao/images/title03.gif" alt="Galerias" /></h1>
            <ul>
                <%if (Model.Ponto.EPontao.HasValue)
                      if (Model.Ponto.Eventos.Count > 0)
                %>
                <% foreach (PontaoCanavial.Models.VOs.Evento e in Model.Ponto.Eventos)
                   {
                %>
                <%Response.Write("<li>");%>
                <p>
                    <%=e.Data %></p>
                <h2>
                    <%=Html.ActionLink(e.Nome, "EventoDetalhe", new { id = e.Id })%></h2>
                <%Response.Write("</li>");%>
                <%} %>
            </ul>
        </div>
    </div>
</asp:Content>
