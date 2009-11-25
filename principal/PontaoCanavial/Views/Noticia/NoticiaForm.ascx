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
        <label for="Logo">
            Imagem:</label>
        <input id="imgImagem" name="imgImagem"  type="file" class="multi" accept="gif|jpg|png" maxlength="1" /></p>
    <p>
        <label for="Nome">
            Título:</label>
        <%= Html.TextBox("Titulo", Model.Titulo)%>
        <%= Html.ValidationMessage("Titulo", "*")%>
    </p>
    <p>
        <label for="NomeIdentificador">
            Preview:</label>
        <%= Html.TextBox("Preview", Model.Preview)%>
        <%= Html.ValidationMessage("Preview", "*")%>
    </p>
    <p>
        <label for="DescricaoOficina">
            Corpo:</label>
        <%= Html.TextBox("Corpo", Model.Corpo)%>
        <%= Html.ValidationMessage("Corpo", "*")%>
    </p>
    <p>
        <input type="submit" value="Save" />
    </p>
</div>
