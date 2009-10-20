<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%= Html.ValidationSummary("Corrija os erros e tente novamente.") %>


    <div id="pontoDiv">
    <p>
    <label for="Logo">
                Logo:</label>
        <input id="imgLogo" type="file" class="multi" accept="gif|jpg" maxlength="1" /></p>
        <p>
            <label for="Nome">
                Nome:</label>
            <%= Html.TextBox("Nome", Model.Ponto.Nome) %>
            <%= Html.ValidationMessage("Nome", "*")%>
        </p>
        <p>
            <label for="NomeIdentificador">
                Nome Identificador:</label>
            <%= Html.TextBox("NomeIdentificador", Model.Ponto.NomeIdentificador)%>
            <%= Html.ValidationMessage("NomeIdentificador", "*")%>
        </p>
        <p>
            <label for="ApresentacaoProjeto">
                Apresentação Projeto:</label>
            <%= Html.TextBox("ApresentacaoProjeto", Model.Ponto.ApresentacaoProjeto)%>
            <%= Html.ValidationMessage("ApresentacaoProjeto", "*")%>
        </p>
        <p>
            <label for="DescricaoOficina">
                Descrição Oficina:</label>
            <%= Html.TextBox("DescricaoOficina", Model.Ponto.DescricaoOficina)%>
            <%= Html.ValidationMessage("DescricaoOficina", "*")%>
        </p>
        <p>
            <label for="EquipeProjeto">
                Equipe Projeto:</label>
            <%= Html.TextBox("EquipeProjeto", Model.Ponto.EquipeProjeto)%>
            <%= Html.ValidationMessage("EquipeProjeto", "*")%>
        </p>
        <p>
            <label for="JustificativaProjeto">
                Justificativa Projeto:</label>
            <%= Html.TextBox("JustificativaProjeto", Model.Ponto.JustificativaProjeto)%>
            <%= Html.ValidationMessage("JustificativaProjeto", "*")%>
        </p>
        <p>
            <label for="ObjetivoProjeto">
                Objetivo Projeto:</label>
            <%= Html.TextBox("ObjetivoProjeto", Model.Ponto.ObjetivoProjeto)%>
            <%= Html.ValidationMessage("ObjetivoProjeto", "*")%>
        </p>
        <p>
            <input type="submit" value="Save" />
        </p>
    </div>
