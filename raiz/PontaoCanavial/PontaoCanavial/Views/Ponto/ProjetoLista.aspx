<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="projetos-list">
            <h1>
                <img src="../../App_Themes/Pontao/images/title07.gif" alt="Galerias" /></h1>
            <ul>
                <%if (Model.Ponto.EPontao.HasValue)
                      if (Model.Ponto.Projetos.Count > 0)
                %>
                <% foreach (PontaoCanavial.Models.VOs.Projeto p in Model.Ponto.Projetos)
                   {
                %>
                <%Response.Write("<li>");%>
                <%=Html.ActionLink(p.Nome, "ProjetoDetalhe", new { id = p.Id })%>
                <%Response.Write("</li>");%>
                <%} %>
            </ul>
        </div>
    </div>
</asp:Content>
