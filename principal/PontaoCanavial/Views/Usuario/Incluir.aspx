<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Usuario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Incluir
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Incluir</h2>
    <%=Html.ValidationSummary("Corrija os erros e tente novamenteo.")%>
    <% using (Html.BeginForm()) {%>

        <fieldset>
            <legend>Fields</legend>
            
           
                <%= Html.LabelFor(model => model.Nome) %>
            
                <%= Html.TextBoxFor(model => model.Nome)%>
                <%= Html.ValidationMessageFor(model => model.Nome,"*")%>
          
            
              <%= Html.LabelFor(model => model.Login) %>
            
                <%= Html.TextBoxFor(model => model.Login)%>
                <%= Html.ValidationMessageFor(model => model.Login, "*")%>
                
                  <%= Html.LabelFor(model => model.Senha) %>
            
                <%= Html.PasswordFor(model => model.Senha)%>
                <%= Html.ValidationMessageFor(model => model.Senha, "*")%>
            
            
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>  

</asp:Content>
