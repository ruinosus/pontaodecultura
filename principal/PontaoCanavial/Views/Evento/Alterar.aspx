<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Evento>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Alterar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Alterar</h2>
    <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Alterar", "Evento", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.DataEvento) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.DataEvento, String.Format("{0:g}", Model.DataEvento)) %>
                <%= Html.ValidationMessageFor(model => model.DataEvento) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Descricao) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Descricao) %>
                <%= Html.ValidationMessageFor(model => model.Descricao) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.ID) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.ID) %>
                <%= Html.ValidationMessageFor(model => model.ID) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Nome) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Nome) %>
                <%= Html.ValidationMessageFor(model => model.Nome) %>
            </div>
                        <%= Html.LabelFor(model => model.ImagemPequena)%>
            
                <%= Html.EditorFor(model => model.ImagemPequena)%>
                
          
                <%= Html.LabelFor(model => model.ImagemMedia)%>
           
                <%= Html.EditorFor(model => model.ImagemMedia)%>
                
           
                <%= Html.LabelFor(model => model.ImagemGrande)%>
            
            
                <%= Html.EditorFor(model => model.ImagemGrande)%>           
            <p>
                <input type="submit" value="Salvar" />
            </p>
        </fieldset>

    <% } %>


</asp:Content>

