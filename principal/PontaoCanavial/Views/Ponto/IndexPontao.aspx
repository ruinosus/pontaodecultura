<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Models.VOs" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="projetos">
            <h1>
                <img src="../../App_Themes/Pontao/images/title07.gif" alt="Projetos" /></h1>
            <% 
                if (Model.Ponto.Projeto.Count > 0)
                    Response.Write("<ul>");
                for (int i = 0; i < Model.Ponto.Projeto.Count; i++)
                {
            %>
            <%Response.Write("<li>");%>
            <%=Html.ActionLink(Model.Ponto.Projeto[i].Nome, "ProjetoDetalhe", new { id = Model.Ponto.Projeto[i].Id })%>
            <%  Response.Write("</li>");%>
            <%
                if (i == 0)
                {
                    Response.Write("</ul>");
                    Response.Write("<ul>");
                }

                if (i + 1 == Model.Ponto.Projeto.Count)
                    Response.Write("</ul>");
            %>
            <% 
                }
            %>
        </div>
        <div id="noticias">
            <h1>
                <img src="../../App_Themes/Pontao/images/title02.gif" alt="Not&iacute;cias" /></h1>
            <% 
                if (Model.Ponto.Noticia.Count > 0)
                    Response.Write("<ul>");
                for (int i = Model.Ponto.Noticia.Count - 1; i >= Model.Ponto.Noticia.Count - 4; i--)
                {
            %>
            <%Response.Write("<li>");%><span>
                <h2>
                    <%=Html.ActionLink(Model.Ponto.Noticia[i].Titulo, "NoticiaDetalhe", new { id = Model.Ponto.Noticia[i].Id })%></h2>
                <h3>
                    <%= Model.Ponto.Noticia[i].DataCriacao %></h3>
                <%if (Model.Ponto.Noticia[i].ImagemPequena != null)
                  {%>
                <% 
                    var imgurl = Url.Action("ThumbImageNoticia", "Image",
                          new { id = Model.Ponto.Noticia[i].Id, width = 80, height = 80, tipo = "P" }); %>
                <%=Html.Image("img", imgurl, "Imagem")%>
                <% }
                  
                %>
                <p>
                    <%=Model.Ponto.Noticia[i].Preview %>
                </p>
            </span>
            <%  Response.Write("</li>");%>
            <%
                if (i == 0)
                {
                    Response.Write("</ul>");
                    Response.Write("<ul>");
                }

                if (i + 1 == Model.Ponto.Noticia.Count)
                    Response.Write("</ul>");
            %>
            <% 
                }
            %>
        </div>
        <div id="galerias">
            <h1>
                <img src="../../App_Themes/Pontao/images/title04.gif" alt="Galerias" /></h1>
            <ul>
                <li>
                    <h2>
                        Lorem ipsum dolor</h2>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_gal1.jpg" alt="foto" /><p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut at libero sagittis vitae
                            scelerisque nibh. Nulla.
                        </p>
                    </span></a></li>
                <li>
                    <h2>
                        Vivamus vel tellus</h2>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_gal2.jpg" alt="foto" /><p>
                            Vivamus vel tellus purus, non sollicitudin lacus. Aliquam ut ultricies lorem.
                        </p>
                    </span></a></li>
            </ul>
        </div>
        <div id="produtos">
            <h1>
                <img src="../../App_Themes/Pontao/images/title05.gif" alt="Produtos" /></h1>
            <% 
                if (Model.Ponto.Produto.Count > 0)
                    Response.Write("<ul>");
                for (int i = Model.Ponto.Produto.Count - 1; i >= Model.Ponto.Produto.Count - 2; i--)
                {
            %>
            <%Response.Write("<li>");%>
            <a href="#"><span>
                <%if (Model.Ponto.Produto[i].ImagemPequena != null)
                  {%>
                <% 
                    var imgurl = Url.Action("ThumbImageProduto", "Image",
                          new { id = Model.Ponto.Produto[i].Id, width = 80, height = 120, tipo = "P" }); %>
                <%=Html.Image("img", imgurl, "Imagem")%>
                <% }
                  
                %>
                <h2><%=Html.ActionLink(Model.Ponto.Produto[i].Nome, "ProdutoLista", new { id = Model.Ponto.Noticia[i].Id })%>
                    </h2>
                <p>
                    <%= Model.Ponto.Produto[i].Categoria.Descricao %></p>
            </span></a>
            <%Response.Write("</li>");%>
            <%} %>
            <%Response.Write("</ul>");%>
        </div>
    </div>
</asp:Content>
