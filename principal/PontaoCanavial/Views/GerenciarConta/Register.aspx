﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>
<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Criando uma nova conta</h2>
    <p>
        Formulário para Nova Conta
    </p>
    <p>
        Senhas com no minimo
        <%=Html.Encode(ViewData["PasswordLength"])%>
        caracteres.
    </p>
    <%= Html.ValidationSummary("Problemas ao criar uma nova conta. Corrija os erros e tente novamente.") %>
    
    <% using (Html.BeginForm())
       { %>
    <div>
        <fieldset>
            <legend>Account Information</legend>
            <p>
                <label for="username">
                    Username:</label>
                <%= Html.TextBox("username") %>
                <%= Html.ValidationMessage("username") %>
            </p>
            <p>
                <label for="email">
                    Email:</label>
                <%= Html.TextBox("email") %>
                <%= Html.ValidationMessage("email") %>
            </p>
            <p>
                <label for="password">
                    Password:</label>
                <%= Html.Password("password") %>
                <%= Html.ValidationMessage("password") %>
            </p>
            <p>
                <label for="confirmPassword">
                    Confirm password:</label>
                <%= Html.Password("confirmPassword") %>
                <%= Html.ValidationMessage("confirmPassword") %>
            </p>
            <p>
                <input type="submit" value="Register" />
            </p>
        </fieldset>
    </div>
    <% } %>
</asp:Content>
