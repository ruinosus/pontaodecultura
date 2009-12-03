<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Models.VOs.Noticia>" %>
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
        <label for="Titulo">
            Título:</label>
        <%= Html.TextBox("Titulo", Model.Titulo)%>
        <%= Html.ValidationMessage("Titulo", "*")%>
    </p>
    <p>
        <label for="Preview">
            Preview:</label>
        <%= Html.TextBox("Preview", Model.Preview)%>
        <%= Html.ValidationMessage("Preview", "*")%>
    </p>
    <p>
        <label for="Corpo">
            Corpo:</label>
        <%= Html.TextBox("Corpo", Model.Corpo)%>
        <%= Html.ValidationMessage("Corpo", "*")%>
    </p>
    <p>
        <label for="PontoId">
            Ponto:</label>
        <%= Html.TextBox("PontoId", Model.PontoId)%>
        <%= Html.ValidationMessage("PontoId", "*")%>
    </p>
    <p>
        <input type="submit" value="Save" />
    </p>
</div>
