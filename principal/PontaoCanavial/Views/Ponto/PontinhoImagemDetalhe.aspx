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
                    <%=Model.ImagemDetalhe.Nome%>
                    - <span>
                        <%--<%=Model.NoticiaDetalhe.Usuario.Nome %>--%></span></h3>
                <p>
                </p>
            </div>
            <div class="not-body">
                <h2>
                    <%=Model.ImagemDetalhe.Descricao%></h2>
                <div class="not-foto">
                    <% 
                        var imgurl = Url.Action("ThumbImageImagem", "Image",
                              new { id = Model.ImagemDetalhe.ID, width = 230, height = 230, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                    
                </div>
             
            </div>
        </div>
    </div>
</asp:Content>
