<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Models.VOs.Projeto>" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<script src="../../Scripts/jquery.js" type="text/javascript"></script>

<script src="../../Scripts/documentation.js" type="text/javascript"></script>

<script src="../../Scripts/jquery.form.js" type="text/javascript" language="javascript"></script>

<script src="../../Scripts/jquery.MetaData.js" type="text/javascript" language="javascript"></script>

<script src="../../Scripts/jquery.MultiFile.js" type="text/javascript" language="javascript"></script>

<script src="../../Scripts/jquery.blockUI.js" type="text/javascript" language="javascript"></script>

<%= Html.ValidationSummary("Corrija os erros e tente novamente.") %>
<div id="pontoDiv">
    <p>
        <label for="imgPequena">
            ImagemPequena:</label>
        <input id="imgPequena" name="imgPequena" type="file" class="multi" accept="gif|jpg|png"
            maxlength="1" /></p>
    <p>
        <p>
            <label for="imgMedia">
                ImagemMedia:</label>
            <input id="imgMedia" name="imgMedia" type="file" class="multi" accept="gif|jpg|png"
                maxlength="1" /></p>
        <p>
            <p>
                <label for="imgGrande">
                    ImagemGrande:</label>
                <input id="imgGrande" name="imgGrande" type="file" class="multi" accept="gif|jpg|png"
                    maxlength="1" /></p>
            <p>
                <label for="Nome">
                    Nome:</label>
                <%= Html.TextBox("Nome", Model.Nome)%>
                <%= Html.ValidationMessage("Nome", "*")%>
            </p>
            <p>
                <label for="Descricao">
                    Descricao:</label>
                <%= Html.TextArea("Descricao", Model.Descricao)%>
                <%= Html.ValidationMessage("Descricao", "*")%>
            </p>
            <p>
                <label for="PontoId">
                    Ponto id:</label>
                <%= Html.TextArea("PontoId", Model.PontoId)%>
                <%= Html.ValidationMessage("PontoId", "*")%>
            </p>
            <p>
                <input type="submit" value="Save" />
            </p>
</div>
