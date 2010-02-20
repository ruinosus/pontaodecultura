<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Newsletter>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Incluir
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Incluir</h2>
    <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Incluir", "Newsletter", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Email) %>
                <%= Html.ValidationMessageFor(model => model.Email) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.ID) %>
            </div>
             
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>


</asp:Content>

