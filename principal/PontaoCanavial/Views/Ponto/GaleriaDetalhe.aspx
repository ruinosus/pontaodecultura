<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
         <div id="galerias">
            <h1>
                  <img src="../../App_Themes/Pontao/images/title04.gif" alt="Galerias" /></h1>
            <div class="not-header">
                <h3>
                    <%=Model.GaleriaDetalhe.Nome%>
                    - <span>
                        <%--<%=Model.NoticiaDetalhe.Usuario.Nome %>--%></span></h3>
                <p>
                </p>
            </div>
            <div class="not-body">
                <h2>
                    <%=Model.GaleriaDetalhe.Descricao%></h2>
                <div class="not-foto">
                    <% 
                        var imgurl = Url.Action("ThumbImageGaleria", "Image",
                              new { id = Model.GaleriaDetalhe.ID, width = 230, height = 230, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                </div>
             <%=     Html.ActionLink("Visualizar Imagens", "ImagemListar", "Ponto", new { id = Model.GaleriaDetalhe.ID }, null)%>
            </div>
        </div>
    </div>
</asp:Content>
