<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontinho.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="pontinhoEventoDetalhe" ContentPlaceHolderID="contentMasterPontinho" runat="server">
    <div id="coluna-2">
        <div id="eventos-text">
            <h1>
                <img src="../../App_Themes/Pontao/images/title03.gif" alt="Eventos" /></h1>
            <p>
                <%=Model.EventoDetalhe.DataEvento %></p>
            <h2>
                <%=Model.EventoDetalhe.Nome %></h2>
            <div class="event-foto">
                <% if (Model.EventoDetalhe.ImagemMedia != null)%>
                    <%{ %>
                    <% 
                        var imgurl = Url.Action("ThumbImageProjeto", "Image",
                              new { id = Model.EventoDetalhe.ID, width = 220, height = 180, tipo = "M" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                    <%} %>
            </div>
            <p>
                <%=Model.EventoDetalhe.Descricao %>
            </p>
        </div>
    </div>
</asp:Content>
