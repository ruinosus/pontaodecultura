<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Categoria>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Listar</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Descricao
            </th>
            <th>
                ID
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Excluir", "Excluir", new { id = item.ID })%>
            </td>
            <td>
                <%= Html.Encode(item.Descricao) %>
            </td>
            <td>
                <%= Html.Encode(item.ID) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Incluir Novo", "Incluir") %>
    </p>

</asp:Content>

