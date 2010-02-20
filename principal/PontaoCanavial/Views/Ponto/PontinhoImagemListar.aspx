<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master" 
Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>"%>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">

     <div id="galerias">
            <h1>
                  <img src="../../App_Themes/Pontao/images/title04.gif" alt="Galerias" /></h1>
            <div class="not-header">
            
            <%foreach (Imagem imagem in Model.ImagenLista)
              {
                  
              %>
                <h3>
                    <%=imagem.Nome%>
                    - <span>
                        <%--<%=Model.NoticiaDetalhe.Usuario.Nome %>--%></span></h3>
                <p>
                </p>
            </div>
            <div class="not-body">
                <h2>
                    <%=imagem.Descricao%></h2>
                <div class="not-foto">
                    <% 
                        var imgurl = Url.Action("ThumbImageImagem", "Image",
                              new { id = imagem.ID, width = 230, height = 230, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                </div>
            <% } %>
            </div>
        </div>
</asp:Content>
