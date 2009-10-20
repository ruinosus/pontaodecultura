<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<% using (Html.BeginForm("Create", "Ponto", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
<fieldset>
    <h2>Create</h2>
<% Html.RenderPartial("PontoForm"); %>
</fieldset>
<% } %>
</asp:Content>
