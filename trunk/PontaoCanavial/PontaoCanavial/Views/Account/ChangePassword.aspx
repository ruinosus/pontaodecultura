<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="changePasswordTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Mudando a senha
</asp:Content>

<asp:Content ID="changePasswordContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Mudando a senha</h2>
    <p>
        Utilize o formulário abaixo para mudar a sua senha. 
    </p>
    <p>
        Senhas com no minimo <%=Html.Encode(ViewData["PasswordLength"])%> caracteres.
    </p>
    <%= Html.ValidationSummary("Senha não alterada. Corrija os erros e tente novamente.")%>

    <% using (Html.BeginForm()) { %>
        <div>
            <fieldset>Informações da Conta</legend>
                <p>
                    <label for="currentPassword">Current password:</label>
                    <%= Html.Password("currentPassword") %>
                    <%= Html.ValidationMessage("currentPassword") %>
                </p>
                <p>
                    <label for="newPassword">New password:</label>
                    <%= Html.Password("newPassword") %>
                    <%= Html.ValidationMessage("newPassword") %>
                </p>
                <p>
                    <label for="confirmPassword">Confirm new password:</label>
                    <%= Html.Password("confirmPassword") %>
                    <%= Html.ValidationMessage("confirmPassword") %>
                </p>
                <p>
                    <input type="submit" value="Change Password" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
