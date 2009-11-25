<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<% using (Html.BeginForm("Create", "Noticia", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
<fieldset>
    <h2>Create</h2>
<% Html.RenderPartial("NoticiaForm"); %>
</fieldset>
<% } %>
</asp:Content>
