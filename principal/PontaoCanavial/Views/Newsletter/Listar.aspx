<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Newsletter>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Listar</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Email
            </th>
            <th>
                ID
            </th>
            <th>
                PontoID
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Alterar", "Alterar", new { id=item.ID }) %> |
                <%= Html.ActionLink("Excluir", "Excluir", new { id=item.ID })%>
            </td>
            <td>
                <%= Html.Encode(item.Email) %>
            </td>
            <td>
                <%= Html.Encode(item.ID) %>
            </td>
            <td>
                <%= Html.Encode(item.PontoID) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Incluir Novo", "Incluir") %>
    </p>

</asp:Content>

