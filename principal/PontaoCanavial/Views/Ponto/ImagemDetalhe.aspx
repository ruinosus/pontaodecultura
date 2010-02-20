<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMasterPontao" runat="server"> 
    
    <div id="Div1">
   		  	<div id="galerias-desc">
            	<h1><img src="images/title04.gif" alt="Galerias" /></h1>
                <ul>
                	<li>                 	  
                    	<span><h2><%=Model.ImagemDetalhe.Nome%></h2></span><p><%=Model.ImagemDetalhe.Descricao%><br/>
                    	</p>
                  </li>
                 </ul>
            </div>
            <div id="div-galeria">
       	    <img src="images/galeria/img/img_001.jpg"/>
            	<ul>
                    <li class="link-anterior"></li>
                    <li class="link-proxima"></li>	
                    <li></li>
				</ul>
            </div>
          </div>
</asp:Content>
