<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Galeria>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Alterar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Alterar</h2>

     <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Alterar", "Noticia", FormMethod.Post, new { enctype = "multipart/form-data" }))
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
            
        
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Nome) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Nome) %>
                <%= Html.ValidationMessageFor(model => model.Nome) %>
            </div>
        
            
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>

