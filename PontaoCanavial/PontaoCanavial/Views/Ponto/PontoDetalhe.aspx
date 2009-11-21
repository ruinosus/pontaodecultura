<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="ponto-text">
            <h1>
                Pont&atilde;o do Canavial</h1>
            <div class="proj-body">

            <b>

                <h2>
                    Apresenta&ccedil;&atilde;o</h2>
                <p>
                    <%= Model.Ponto.Apresentacao %>
                </p>
                <h2>
                    Justificativa</h2>
                <p>
                    <%= Model.Ponto.Justificativa %></p>
                <h2>
                    Objetivo</h2>
                <p>
                    <%= Model.Ponto.Objetivo %>
                </p>
                <h2>
                    Equipe</h2>
                <ul>
                    <li>
                        <p>
                            <%= Model.Ponto.Equipe %></p>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
