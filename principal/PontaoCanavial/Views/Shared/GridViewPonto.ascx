<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Ponto>" %>


<tr>
<td>Nome do Ponto</td><td><%=Model.Nome %> </td>
<td>Nome Identificador</td><td><%=Model.NomeIdentificador%> </td>
<td><%=     Html.ActionLink("Alterar Ponto", "Alterar","Ponto", new { id = Model.ID},null)%></td>
<td><%=     Html.ActionLink("Selecionar Ponto", "SelecionarPonto","PainelAdministrador", new { id = Model.ID},null)%></td>
</tr>
