<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Models.VOs" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<%if (Model.Ponto == null)
  {
      Response.Redirect("NaoEncontrado", false);
  }      
%>
<b>
    <%if (Model.Ponto.Logo != null)
      {%>
      <% 
          var imgurl = Url.Action("ThumbImage", "Image", 
                new { id = Model.Ponto.Id,width=100,height=100 }); %>
                <img src="<%=imgurl %>"  alt=""/>
    <% }%>
    <%=
        Html.Encode(Model.Ponto.Nome)
    %></b>
<br />
<%
    if (Model.Ponto.EPontao.HasValue)
        if (Model.Ponto.EPontao.Value)
            foreach (Ponto ponto in Model.Pontinhos)
            {
%>
<%=     Html.ActionLink(ponto.Nome, "Index", new { nomeIdentificador = ponto.NomeIdentificador})%>
<br />
<%
    }
%>
