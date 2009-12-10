<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>
    
        <% using (Html.BeginForm("Edit", "Noticia", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
<fieldset>
    <h2>Edit</h2>
<% Html.RenderPartial("NoticiaForm"); %>
</fieldset>
<% } %>

</asp:Content>
