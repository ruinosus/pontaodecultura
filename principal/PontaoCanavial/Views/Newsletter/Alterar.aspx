<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Newsletter>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Alterar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Alterar</h2>

    <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Alterar", "Newsletter", FormMethod.Post, new { enctype = "multipart/form-data" }))
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
                      
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>


</asp:Content>

