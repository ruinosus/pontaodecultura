<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Controllers.PontoFormViewModel>" %>



<%= Html.ValidationSummary("Corrija os erros e tente novamente.") %>

<% using (Html.BeginForm()) { %>

    <fieldset>

        <div id="dinnerDiv">

        <p>
            <label for="Nome">Nome:</label>
            <%= Html.TextBox("Nome", Model.Ponto.Nome) %>
            <%= Html.ValidationMessage("Nome", "*")%>
        </p>
        
        <p>
            <label for="NomeIdentificador">Nome Identificador:</label>
            <%= Html.TextBox("NomeIdentificador", Model.Ponto.NomeIdentificador)%>
            <%= Html.ValidationMessage("NomeIdentificador", "*")%>
        </p>
                         
        <p>
            <input type="submit" value="Save" />
        </p>
            
        </div>
        
         
            
    </fieldset>

    

<% } %>