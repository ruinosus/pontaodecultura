<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Ponto>" %>


<tr>
<td><%=Model.Nome %> </td>
<td><%=Model.NomeIdentificador%> </td>
<td><%=     Html.ActionLink("Alterar Ponto", "Alterar","Ponto", new { id = Model.ID},null)%></td>
<td><%=     Html.ActionLink("Selecionar Ponto", "SelecionarPonto","PainelAdministrador", new { id = Model.ID},null)%></td>
</tr>
