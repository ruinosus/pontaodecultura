<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PainelAdministrador
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>PainelAdministrador</h2>
    
    <%=     Html.ActionLink("Verificar Notícias", "Listar","Noticia", null,null)%>

</asp:Content>
