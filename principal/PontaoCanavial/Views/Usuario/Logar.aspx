<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Usuario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Logar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <h2>logar</h2>
    <p>
        Informe o seu login e a senha. 
    </p>
    <%= Html.ValidationSummary(true, "Login ou senha inválidos.") %>

    <% using (Html.BeginForm()) { %>
        <div>
            <fieldset>
                <legend>Informações da Conta</legend>
                
                <div class="editor-label">
                    <%= Html.LabelFor(m => m.Login) %>
                </div>
                <div class="editor-field">
                    <%= Html.TextBoxFor(m => m.Login)%>
                    <%= Html.ValidationMessageFor(m => m.Login,"*")%>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(m => m.Senha) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(m => m.Senha) %>
                    <%= Html.ValidationMessageFor(m => m.Senha, "*")%>
                </div>
                
                <p>
                    <input type="submit" value="Entrar" />
                </p>
            </fieldset>
        </div>
    <% } %>

</asp:Content>
