<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Usuario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Alterar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Alterar</h2>
    <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
  <% using (Html.BeginForm("Alterar", "Usuario", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>

        <fieldset>
            <legend>Campos</legend>
            <%Html.HiddenFor(model => model.ID); %>
                <%= Html.LabelFor(model => model.Senha) %>
            
                <%= Html.PasswordFor(model => model.Senha)%>
                <%= Html.ValidationMessageFor(model => model.Senha, "*")%>
            
            
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>
