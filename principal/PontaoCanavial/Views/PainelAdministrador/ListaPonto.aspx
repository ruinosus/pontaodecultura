<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<UsuarioPonto>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ListaPonto
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        ListaPonto</h2>
    <table>
        <tr>
            <th>
                Nome do Ponto
            </th>
            <th>
                Nome Identificador
            </th>
            <th>
                Alterar
            </th>
            <th>
                Selecionar
            </th>
        </tr>
        <%foreach (var item in this.Model)
          {  %>
        <% 
            Html.RenderPartial("GridViewPonto", item.Ponto); 
        %>
        <%} %>
    </table>
</asp:Content>
