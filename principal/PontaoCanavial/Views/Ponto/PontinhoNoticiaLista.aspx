<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontinho.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="pontinhoNoticiaLista" ContentPlaceHolderID="contentMasterPontinho"
    runat="server">
    <div id="coluna-2">
        <div id="noticias-list">
            <h1>
                <img src="../../App_Themes/Pontao/images/title02.gif" alt="Not&iacute;cias" /></h1>
            <ul>
                <%if (!Model.Ponto.EPontao.HasValue || !Model.Ponto.EPontao.Value)

                      if (Model.Ponto.Noticia.Count > 0)
                %>
                <% foreach (PontaoCanavial.Models.VOs.Noticia n in Model.Ponto.Noticia)
                   {
                %>
                <%Response.Write("<li>");%>
                <a href=""><span>
                    <%if (n.ImagemPequena != null)
                      {%>
                    <% 
                        var imgurl = Url.Action("ThumbImageNoticia", "Image",
                              new { id = n.Id, width = 80, height = 80, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                    <% }
                  
                    %><p class="titulo-noticia">
                        <%=Html.ActionLink(n.Titulo, "PontinhoNoticiaDetalhe", new { id = n.Id })%></p>
                    <h3>
                        <%=n.DataCriacao%></h3>
                    <p class="texto-preview">
                        <%=n.Preview%></p>
                </span></a>
                <%  Response.Write("</li>");%>
                <% 
                    }
                %>
            </ul>
        </div>
    </div>
</asp:Content>
