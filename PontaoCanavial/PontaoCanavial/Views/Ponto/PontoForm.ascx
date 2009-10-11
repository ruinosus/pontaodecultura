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
                'fileDesc': 'Aruivos de Imagem',
                'simUploadLimit': 2,
                'fileExt': '*.jpg;*.gif',
                'sizeLimit': '4000000',
                auto: true
            });
        });
    </script>    
    </head>
    
<%= Html.ValidationSummary("Corrija os erros e tente novamente.") %>
<% using (Html.BeginForm("SaveImage", "Image", FormMethod.Post, new { enctype = "multipart/form-data" })) {%>
<fieldset>
<label for="photo">Insira a sua foto:</label><input type="file" id="photo" name="photo" /><br />
</fieldset>
<%} %>
<% using (Html.BeginForm("Create", "Ponto", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
<fieldset>
    <div id="pontoDiv">
        <input id="imgLogo" type="file"  class="multi" accept="gif|jpg" maxlength="2" />

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
        </p>
        <p>
            <input type="submit" value="Save" />
        </p>
    </div>
</fieldset>
<% } %>