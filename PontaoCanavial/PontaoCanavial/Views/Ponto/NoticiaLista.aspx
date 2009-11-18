<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="Div1">
        <div id="noticias-list">
            <h1>
                <img src="../../App_Themes/Pontao/images/title02.gif" alt="Not&iacute;cias" /></h1>
            <ul>
                <%if (Model.Ponto.EPontao.HasValue)
                      if (Model.Ponto.Noticias.Count > 0)
                %>
                <% foreach (PontaoCanavial.Models.VOs.Noticia n in Model.Ponto.Noticias)
                   {
                %>
                <%Response.Write("<li>");%>
                <%=     Html.ActionLink(n.Titulo, "NoticiaDetalhe", new { id = n.Id })%><span><img src=<%=  n.ImagemPequena   %> alt="foto" /><h2><%=  n.Titulo   %></h2><h3><%=  n.DataCriacao   %></h3><p><%=  n.Preview   %></p></span>
                
                  <%if (Model.Ponto.Logo != null)
                  {%>
                <% 
                    var imgurl = Url.Action("ThumbImage", "Image",
                          new { id = Model.Ponto.Id, width = 231, height = 207 }); %>
                <%=Html.Image("img", imgurl, "Imagem")%>
                <% }
                  
                %>
                
                <%  Response.Write("</li>");%>
                <% 
                    } %>
            </ul>
        </div>
               
    </div>

</asp:Content>
