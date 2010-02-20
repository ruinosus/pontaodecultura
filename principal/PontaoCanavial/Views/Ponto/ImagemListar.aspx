<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master" 
Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>"%>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">          
            <div id="coluna-2">
   		  	<div id="galerias-list">
            	<h1><img src="images/title04.gif" alt="Galerias" /></h1>
                <ul>
            <%foreach (Imagem imagem in Model.ImagemLista)
              {                  
              %>
                <%Response.Write("<li>");%>                	              	  
                    	<a href="#"><span>
                    	<%if (imagem.ImagemPequena != null)
                      {%>
                    <% 
                        var imgurl = Url.Action("ThumbImageImagem", "Image",
                              new { id = imagem.ID, width = 100, height = 100, tipo = "P" }); %>
                    <%=Html.Image("img", imgurl, "Imagem")%>
                    <% } %>
                    
                    <h2>
                    <%=Html.ActionLink(imagem.Nome, "ImagemDetalhe", "Ponto", new { id = imagem.ID }, null)%></p></h2></span></a><p><%=imagem.Descricao%></p>
                <%  Response.Write("</li>");%>
                <% 
                    } %>                        
                 </ul>
            </div>
            </div>
</asp:Content>
