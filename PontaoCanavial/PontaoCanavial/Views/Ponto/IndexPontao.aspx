<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontao.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Models.VOs" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontao" runat="server">
    <div id="coluna-2">
        <div id="projetos">
            <h1>
                <img src="../../App_Themes/Pontao/images/title07.gif" alt="Not&iacute;cias" /></h1>
            <ul>
                <li><a href="#">Programa Canavial</a></li>
                <li><a href="#">Ponto de Leitura</a></li>
                <li><a href="#">Grava&ccedil;&otilde;es de CDs</a></li>
                <li><a href="#">CD Kaosnavial</a></li>
                <li><a href="#">Festival Canavial</a></li>
                <li><a href="#">Document&aacute;rio Kaosnavial</a></li>
            </ul>
            <ul>
                <li><a href="#">Caminhos do Canavial</a></li>
                <li><a href="#">Manuten&ccedil;&atilde;o das Pretinhas do Congo</a></li>
                <li><a href="#">Gri&ocirc; Estrela de Ouro 2009-2010</a></li>
                <li><a href="#">Ponto de Hist&oacute;ria</a></li>
                <li><a href="#">Cine Club Cine Mata</a></li>
            </ul>
        </div>
        <div id="noticias">
            <h1>
                <img src="../../App_Themes/Pontao/images/title02.gif" alt="Not&iacute;cias" /></h1>
            <ul>
                <li>
                    <h2>
                        Lorem ipsum dolor</h2>
                    <h3>
                        14.09.2009</h3>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_not1.jpg" alt="foto" /><p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut at libero sagittis vitae
                            scelerisque nibh. Nulla.
                        </p>
                    </span></a></li>
                <li>
                    <h2>
                        Vivamus vel tellus</h2>
                    <h3>
                        26.08.2009</h3>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_not2.jpg" alt="foto" /><p>
                            Vivamus vel tellus purus, non sollicitudin lacus. Aliquam ut ultricies lorem. Nunc
                            eu mauris purus. Ullamcorper.
                        </p>
                    </span></a></li>
                <li>
                    <h2>
                        Vestibulum ante ipsum</h2>
                    <h3>
                        14.08.2009</h3>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_not3.jpg" alt="foto" /><p>
                            Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia
                            Curae; Nunc ante justo.
                        </p>
                    </span></a></li>
                <li>
                    <h2>
                        Donec eu purus</h2>
                    <h3>
                        05.08.2009</h3>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_not4.jpg" alt="foto" /><p>
                            Donec eu purus eu quam blandit blandit nec nec turpis. Vestibulum ante ipsum primis
                            in faucibus.
                        </p>
                    </span></a></li>
            </ul>
        </div>
        <div id="galerias">
            <h1>
                <img src="../../App_Themes/Pontao/images/title04.gif" alt="Galerias" /></h1>
            <ul>
                <li>
                    <h2>
                        Lorem ipsum dolor</h2>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_gal1.jpg" alt="foto" /><p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut at libero sagittis vitae
                            scelerisque nibh. Nulla.
                        </p>
                    </span></a></li>
                <li>
                    <h2>
                        Vivamus vel tellus</h2>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontao/images/foto_gal2.jpg" alt="foto" /><p>
                            Vivamus vel tellus purus, non sollicitudin lacus. Aliquam ut ultricies lorem.
                        </p>
                    </span></a></li>
            </ul>
        </div>
        <div id="produtos">
            <h1>
                <img src="../../App_Themes/Pontao/images/title05.gif" alt="Produtos" /></h1>
            <ul>
                <li><a href="#"><span>
                    <img src="../../App_Themes/Pontao/images/foto_pro1.jpg" alt="foto" /><h2>
                        Maracatu Estrela de Ouro de Alian&ccedil;a: a saga de uma tradi&ccedil;&atilde;o</h2>
                    <p>
                        Severino Vicente</p>
                </span></a></li>
                <li><a href="#"><span>
                    <img src="../../App_Themes/Pontao/images/foto_pro2.jpg" alt="foto" /><h2>
                        Maracatu Rural: o espet&aacute;culo como espa&ccedil;o social</h2>
                    <p>
                        Ana Val&eacute;ria Vicente.</p>
                </span></a></li>
            </ul>
        </div>
    </div>
    
    
</asp:Content>
