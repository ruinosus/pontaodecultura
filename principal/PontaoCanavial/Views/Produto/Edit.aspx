<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">

    <h2>Edit</h2>
    
        <% using (Html.BeginForm("Edit", "Produto", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
<fieldset>
    <h2>Edit</h2>
<% Html.RenderPartial("ProdutoForm"); %>
</fieldset>
<% } %>

</asp:Content>
