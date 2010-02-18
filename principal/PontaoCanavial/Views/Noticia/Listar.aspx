<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Noticia>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Listar</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Corpo
            </th>
            <th>
                DataCriacao
            </th>
            <th>
                ID
            </th>
            <th>
                PontoID
            </th>
            <th>
                Preview
            </th>
            <th>
                Titulo
            </th>
            <th>
                UsuarioID
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Alterar", "Alterar", new { id=item.ID }) %> |
               <%= Html.ActionLink("Excluir", "Excluir", new { id = item.ID })%>
            </td>
            <td>
                <%= Html.Encode(item.Corpo) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:g}", item.DataCriacao)) %>
            </td>
            <td>
                <%= Html.Encode(item.ID) %>
            </td>
            <td>
                <%= Html.Encode(item.PontoID) %>
            </td>
            <td>
                <%= Html.Encode(item.Preview) %>
            </td>
            <td>
                <%= Html.Encode(item.Titulo) %>
            </td>
            <td>
                <%= Html.Encode(item.UsuarioID) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Incluir Nova", "Incluir") %>
    </p>

</asp:Content>

