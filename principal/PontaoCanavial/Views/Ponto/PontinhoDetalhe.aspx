<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontinho.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="pontinhoDetalhe" ContentPlaceHolderID="contentMasterPontinho" runat="server">
    <div id="coluna-2">
        <div id="ponto-text">
            <h1>
                Pont&atilde;o do Canavial</h1>
            <div class="proj-body">

            <b>
                <%if (Model.Ponto.ImagemMedia != null)
                  {%>
                <% 
                    var imgurl = Url.Action("ThumbImagePontoDetalhe", "Image",
                          new { id = Model.Ponto.ID, width = 231, height = 207, tipo="m" }); %>
                <%=Html.Image("img", imgurl, "Imagem")%>
                <% }
                  
                %>
                <h2>
                    Apresenta&ccedil;&atilde;o</h2>
                <p>
                    <%= Model.Ponto.Apresentacao %>
                </p>
                <h2>
                    Justificativa</h2>
                <p>
                    <%= Model.Ponto.Justificativa %></p>
                <h2>
                    Objetivo</h2>
                <p>
                    <%= Model.Ponto.Objetivo %>
                </p>
                <h2>
                    Equipe</h2>
                <ul>
                    <li>
                        <p>
                            <%= Model.Ponto.Equipe %></p>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
