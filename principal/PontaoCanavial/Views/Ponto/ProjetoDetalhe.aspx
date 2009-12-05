<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="projetos-text">
            <h1>                
                <img src="../../App_Themes/Pontao/images/title07.gif" alt="Projetos" /></h1>
            <div class="proj-body">
                <h2>
                    <%=Model.ProjetoDetalhe.Nome %></h2>
                <div class="proj-foto">
                    <% if (Model.ProjetoDetalhe.ImagemPequena != null)                           
                    { 
                           %>
                    <% 
                        var imgurl = Url.Action("ThumbImageProjeto", "Image",
                              new { id = Model.ProjetoDetalhe.Id, width = 220, height = 180, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                    <%} %>
                </div>
                <p>
                    <%=Model.ProjetoDetalhe.Descricao %></p>
            </div>
        </div>
    </div>
</asp:Content>
