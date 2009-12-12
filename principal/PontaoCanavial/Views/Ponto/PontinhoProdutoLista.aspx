<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontinho.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="pontinhoProdutoLista" ContentPlaceHolderID="contentMasterPontinho" runat="server">
    <div id="coluna-2">
        <div id="produtos-list">
            <h1>
                <img src="../../App_Themes/Pontao/images/title05.gif" alt="Produtos" /></h1>
            <ul>
                <%if ((!Model.Ponto.EPontao.HasValue || !Model.Ponto.EPontao.Value))
                      if (Model.Ponto.Produto.Count > 0)
                %>
                <% foreach (PontaoCanavial.Models.VOs.Produto p in Model.Ponto.Produto)
                   {
                %>
                <%Response.Write("<li>");%>
                <%if (p.ImagemPequena != null)
                  {%>
                <% 
                    var imgurl = Url.Action("ThumbImageProduto", "Image",
                          new { id = p.Id, width = 80, height = 100, tipo = "P" }); %>
                <%=Html.Image("img", imgurl, "Imagem")%>
                <% }
                  
                %>
                <h2>
                    <%=p.Nome %>
                </h2>
                <p>
                    <span><%=p.Categoria.Descricao %>></span></p>
                <p>
                    <%=p.Descricao %></p>
                <%Response.Write("</li>");%>
                <%} %>
            </ul>
        </div>
    </div>
</asp:Content>
