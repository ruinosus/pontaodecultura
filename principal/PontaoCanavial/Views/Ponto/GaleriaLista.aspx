<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
          <div id="coluna-2">
   		  	<div id="galerias-list">
            	<h1><img src="images/title04.gif" alt="Galerias" /></h1>
                <ul>
                <%if (Model.Ponto.EPontao.HasValue)
                      if (Model.Ponto.Galeria.Count > 0)
                %>
                <% foreach (Galeria g in Model.Ponto.Galeria)
                   {
                %>
                <%Response.Write("<li>");%>                	              	  
                    	<a href="#"><span>
                    	<%if (g.ImagemPequena != null)
                      {%>
                    <% 
                        var imgurl = Url.Action("ThumbImageGaleria", "Image",
                              new { id = g.ID, width = 100, height = 100, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                    <% } %>                    
                    <h2>
                    <%=Html.ActionLink(g.Nome, "ImagemListar", "Ponto", new { id = g.ID }, null)%></p></h2></span></a><p><%=g.Descricao%></p>
                <%  Response.Write("</li>");%>
                <% 
                    } %>                        
                 </ul>
            </div>
            </div>
</asp:Content>
