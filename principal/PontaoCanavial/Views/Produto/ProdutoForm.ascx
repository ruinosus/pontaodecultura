<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Models.VOs.Produto>" %>
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
            Imagem pequena:</label>
        <input id="imgPequena" name="imgPequena" type="file" class="multi" accept="gif|jpg|png"
            maxlength="1" /></p>
    <p>
        <label for="imgMedia">
            Imagem Media:</label>
        <input id="imgMedia" name="imgMedia" type="file" class="multi" accept="gif|jpg|png"
            maxlength="1" /></p>
    <p>
        <label for="imgGrande">
            Imagem pequena:</label>
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
        <%= Html.TextBox("Descricao", Model.Descricao)%>
        <%= Html.ValidationMessage("Descricao", "*")%>
    </p>
    <p>
        <label for="CategoriaId">
            Categoria:</label>
        <%= Html.TextBox("CategoriaId", Model.CategoriaId)%>
        <%= Html.ValidationMessage("CategoriaId", "*")%>
    </p>
    <p>
        <input type="submit" value="Save" />
    </p>
</div>
