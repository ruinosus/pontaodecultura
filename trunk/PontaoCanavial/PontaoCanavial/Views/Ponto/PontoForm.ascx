<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Controllers.PontoFormViewModel>" %>

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
        <input id="imgLogo" name="imgLogo"  type="file" class="multi" accept="gif|jpg|png" maxlength="1" /></p>
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
        <label for="DescricaoOficina">
            Descrição Oficina:</label>
        <%= Html.TextBox("DescricaoOficina", Model.Ponto.DescricaoOficina)%>
        <%= Html.ValidationMessage("DescricaoOficina", "*")%>
    </p>
    <p>
        <input type="submit" value="Save" />
    </p>
</div>
