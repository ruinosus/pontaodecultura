<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Models.ModuloPonto.VOs.PontoFormViewModel>" %>


<script src="../../Scripts/jquery.js" type="text/javascript"></script>

<script src="../../Scripts/documentation.js" type="text/javascript"></script>

<script src="../../Scripts/jquery.form.js" type="text/javascript" language="javascript"></script>

<script src="../../Scripts/jquery.MetaData.js" type="text/javascript" language="javascript"></script>

<script src="../../Scripts/jquery.MultiFile.js" type="text/javascript" language="javascript"></script>

<script src="../../Scripts/jquery.blockUI.js" type="text/javascript" language="javascript"></script>

<%= Html.ValidationSummary("Corrija os erros e tente novamente.") %>
<div id="pontoDiv">

    <p>
        <label for="Logo">
            Logo:</label>
        <input id="imgLogo" name="imgLogo" type="file" class="multi" accept="gif|jpg|png"
            maxlength="1" /></p>
    <p>
        <p>
            <label for="Cabecalho">
                Cabecalho:</label>
            <input id="Cabecalho" name="Cabecalho" type="file" class="multi" accept="swf|gif|jpg|png"
                maxlength="1" /></p>
        <p>

            <p>
                <label for="ImagemPequena">
                    ImagemPequena:</label>
                <input id="imgPequena" name="imgPequena" type="file" class="multi" accept="gif|jpg|png"
                    maxlength="1" /></p>

            <p>
                <p>
                    <label for="ImagemMedia">
                        ImagemMedia:</label>
                    <input id="imgMedia" name="imgMedia" type="file" class="multi" accept="gif|jpg|png"
                        maxlength="1" /></p>
                <p>
                    <p>
                        <label for="ImagemGrande">
                            ImagemGrande:</label>
                        <input id="imgGrande" name="imgGrande" type="file" class="multi" accept="gif|jpg|png"
                            maxlength="1" /></p>
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
                        <label for="Apresentacao">
                            Apresentação:</label>
                        <%= Html.TextArea("Apresentacao", Model.Ponto.Apresentacao)%>
                        <%= Html.ValidationMessage("Apresentacao", "*")%>
                    </p>
                    <p>
                        <label for="Objetivo">
                            Objetivo:</label>
                        <%= Html.TextArea("Objetivo", Model.Ponto.Objetivo)%>
                        <%= Html.ValidationMessage("Objetivo", "*")%>
                    </p>
                    <p>
                        <label for="Equipe">
                            Equipe:</label>
                        <%= Html.TextArea("Equipe", Model.Ponto.Equipe)%>
                        <%= Html.ValidationMessage("Equipe", "*")%>
                    </p>
                    <p>
                        <label for="Justificativa">
                            Justificativa:</label>
                        <%= Html.TextArea("Justificativa", Model.Ponto.Justificativa)%>
                        <%= Html.ValidationMessage("Justificativa", "*")%>
                    </p>
                    <p>
                        <label for="Contato">
                            Contato:</label>
                        <%= Html.TextArea("Contato", Model.Ponto.Contato)%>
                        <%= Html.ValidationMessage("Contato", "*")%>
                    </p>
                    <p>
                        <label for="EPontao">
                            Pontao:</label>
                        <%= Html.TextBox("EPontao", Model.Ponto.EPontao)%>
                        <%= Html.ValidationMessage("EPontao", "*")%>
                    </p>
                    <p>
                        <input type="submit" value="Save" />
                    </p>
</div>
