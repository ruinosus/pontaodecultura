<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="noticias-text">
            <h1>
                <img src="../../App_Themes/Pontao/images/title02.gif" alt="Not&iacute;cias" /></h1>
            <div class="not-header">
                <h3>
                    <%=Model.NoticiaDetalhe.DataCriacao %>
                    - <span>
                        <%--<%=Model.NoticiaDetalhe.Usuario.Nome %>--%></span></h3>
                <p>
                </p>
            </div>
            <div class="not-body">
                <h2>
                    <%=Model.NoticiaDetalhe.Titulo %></h2>
                <div class="not-foto">
                    <% 
                        var imgurl = Url.Action("ThumbImageNoticia", "Image",
                              new { id = Model.NoticiaDetalhe.ID, width = 230, height = 230, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                </div>
                <p>
                    <%= Model.NoticiaDetalhe.Corpo %></p>
            </div>
        </div>
    </div>
</asp:Content>
