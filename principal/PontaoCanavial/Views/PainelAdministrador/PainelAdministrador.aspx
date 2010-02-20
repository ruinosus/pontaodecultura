<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PainelAdministrador
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>PainelAdministrador</h2>
    
    <%=     Html.ActionLink("Verificar Notícias", "Listar","Noticia", null,null)%>
    <%=     Html.ActionLink("Verificar Projetos", "Listar","Projeto", null,null)%>
    <%=     Html.ActionLink("Verificar Eventos", "Listar","Evento", null,null)%>
    <%=     Html.ActionLink("Verificar Produtos", "Listar","Produto", null,null)%>
    <%=     Html.ActionLink("Verificar Galerias", "Listar","Galeria", null,null)%>

</asp:Content>
