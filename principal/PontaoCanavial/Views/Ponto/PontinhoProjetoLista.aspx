<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontinho.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="pontinhoProjetoLista" ContentPlaceHolderID="contentMasterPontinho" runat="server">
    <div id="coluna-2">
        <div id="projetos-list">
            <h1>
                <img src="../../App_Themes/Pontao/images/title07.gif" alt="Galerias" /></h1>
            <ul>
                <%if (Model.Ponto.EPontao.HasValue)
                      if (Model.Ponto.Projeto.Count > 0)
                %>
                <% foreach (PontaoCanavial.Models.VOs.Projeto p in Model.Ponto.Projeto)
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