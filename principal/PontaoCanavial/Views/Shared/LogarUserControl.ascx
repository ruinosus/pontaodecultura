<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (PontaoCanavial.Models.ModuloBasico.VOs.ClasseAuxiliar.UsuarioLogado!= null) {
%>
        Bem Vindo, <b><%= Html.Encode(PontaoCanavial.Models.ModuloBasico.VOs.ClasseAuxiliar.UsuarioLogado.Nome)%></b>!
        [ <%= Html.ActionLink("Deslogar", "Deslogar", "Usuario") %> ]
<%
    }
    else {
%> 
        [ <%= Html.ActionLink("Logar", "Logar", "Usuario")%> ]
<%
    }
%>
