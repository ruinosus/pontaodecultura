<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<PontaoCanavial.Controllers.PontoFormViewModel>" %>
<head>

    <script src="../../Scripts/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="../../Scripts/jquery.MultiFile.js" type="text/javascript"></script>

    <script src="../../Scripts/MultiFileExemplo.js" type="text/javascript"></script>

    <script src="../../Scripts/swfobject.js" type="text/javascript"></script>

    <script src="../../Scripts/jquery.uploadify.v2.1.0.min.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $('#photo').uploadify({
                'uploader': '/content/uploadify.swf',
                'script': '<%=Url.Action("SaveImage","Image") %>',
                'multi': 'true',
                'buttonText': 'Procurar',
                'cancelImg': '/content/cancel.png',
                'fileDesc': 'Arquivos de Imagem',
                'simUploadLimit': 2,
                'fileExt': '*.jpg;*.gif',
                'sizeLimit': '4000000',
                auto: true
            });
        });
    </script>

</head>
<%= Html.ValidationSummary("Corrija os erros e tente novamente.") %>
<% using (Html.BeginForm("SaveImage", "Image", FormMethod.Post, new { enctype = "multipart/form-data" }))
   {%>
<fieldset>
    <label for="photo">
        Insira a sua foto:</label><input type="file" id="photo" name="photo" /><br />
</fieldset>
<%} %>
<% using (Html.BeginForm("Create", "Ponto", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
<fieldset>
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
</fieldset>
<% } %>