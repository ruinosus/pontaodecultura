<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Noticia>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Incluir
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Incluir</h2>
    <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Alterar", "Noticia", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>


        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Corpo) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Corpo) %>
                <%= Html.ValidationMessageFor(model => model.Corpo) %>
            </div>
            
        
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Preview) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Preview) %>
                <%= Html.ValidationMessageFor(model => model.Preview) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Titulo) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Titulo) %>
                <%= Html.ValidationMessageFor(model => model.Titulo) %>
            </div>
            
             <%= Html.LabelFor(model => model.ImagemPequena)%>
            
                <%= Html.EditorFor(model => model.ImagemPequena)%>
                
          
                <%= Html.LabelFor(model => model.ImagemMedia)%>
           
                <%= Html.EditorFor(model => model.ImagemMedia)%>
                
           
                <%= Html.LabelFor(model => model.ImagemGrande)%>
            
            
                <%= Html.EditorFor(model => model.ImagemGrande)%>
                    
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>

