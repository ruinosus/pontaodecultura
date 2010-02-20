<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Categoria>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Incluir
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Incluir</h2>

     <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Incluir", "Categoria", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Descricao) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Descricao) %>
                <%= Html.ValidationMessageFor(model => model.Descricao) %>
            </div>
                       
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>

