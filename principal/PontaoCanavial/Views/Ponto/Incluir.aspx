<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ponto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Incluir
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Incluir</h2>
    <%=Html.ValidationSummary("Corrija os erros e tente novamente.")%>
<% using (Html.BeginForm("Incluir", "Ponto", FormMethod.Post, new { enctype = "multipart/form-data" }))
   { %>

        <fieldset>
            <legend>Fields</legend>
            
           
                <%= Html.LabelFor(model => model.Apresentacao)%>
            
                <%= Html.TextBoxFor(model => model.Apresentacao)%>
                <%= Html.ValidationMessageFor(model => model.Apresentacao)%>
          
            
            
                <%= Html.LabelFor(model => model.Contato)%>
            
                <%= Html.TextBoxFor(model => model.Contato)%>
                <%= Html.ValidationMessageFor(model => model.Contato)%>
            
            
            
              
           
                <%= Html.LabelFor(model => model.Equipe)%>
            
                <%= Html.TextBoxFor(model => model.Equipe)%>
                <%= Html.ValidationMessageFor(model => model.Equipe)%>
           
            
            
            
           
                <%= Html.LabelFor(model => model.Justificativa)%>
            
                <%= Html.TextBoxFor(model => model.Justificativa)%>
                <%= Html.ValidationMessageFor(model => model.Justificativa)%>
           
            
                <%= Html.LabelFor(model => model.Nome)%>
            
                <%= Html.TextBoxFor(model => model.Nome)%>
                <%= Html.ValidationMessageFor(model => model.Nome, "*")%>
            
            
           
                <%= Html.LabelFor(model => model.NomeIdentificador)%>
            
                <%= Html.TextBoxFor(model => model.NomeIdentificador)%>
                <%= Html.ValidationMessageFor(model => model.NomeIdentificador, "*")%>
            
                <%= Html.LabelFor(model => model.Objetivo)%>
           
                <%= Html.TextBoxFor(model => model.Objetivo)%>
                <%= Html.ValidationMessageFor(model => model.Objetivo)%>
           
                <%= Html.LabelFor(model => model.ImagemPequena)%>
            
                <%= Html.EditorFor(model => model.ImagemPequena)%>
                
          
                <%= Html.LabelFor(model => model.ImagemMedia)%>
           
                <%= Html.EditorFor(model => model.ImagemMedia)%>
                
           
                <%= Html.LabelFor(model => model.ImagemGrande)%>
            
            
                <%= Html.EditorFor(model => model.ImagemGrande)%>
                
                
                <%= Html.LabelFor(model => model.Logo)%>
            
            
                <%= Html.EditorFor(model => model.Logo)%>
                
                
            
            
            <p>
                <input type="submit" value="Confirmar" />
            </p>
        </fieldset>

    <% } %>


</asp:Content>

