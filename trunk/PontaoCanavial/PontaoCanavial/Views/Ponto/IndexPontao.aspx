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
    <div id="coluna-3">
        <div id="buscar">
            <h1>
                <img src="../../App_Themes/Pontao/images/title01.gif" alt="Buscar" /></h1>
            <form id="form1" name="form1" method="post" action="">
            <p>
                <label>
                    <input name="Buscar" type="text" id="Buscar" value="Buscar" /></label></p>
            <p>
                <label>
                    <select name="diretorio" id="diretorio">
                        <option selected="selected">No Pontão do Canavial</option>
                        <option>No Alafiá</option>
                        <option>No Boi de Macuca</option>
                        <option>No Cinema de Animação</option>
                        <option>No Engenho dos Maracatus</option>
                        <option>No Estrela de Ouro</option>
                        <option>No Ororubá</option>
                        <option>No Poço Comprido</option>
                        <option>No Retretas</option>
                    </select></label></p>
            <p>
                <input type="image" src="../../App_Themes/Pontao/images/buscar_btn.gif" align="right" /></p>
            </form>
        </div>
        <div id="eventos">
            <h1>
                <img src="../../App_Themes/Pontao/images/title03.gif" alt="Buscar" /></h1>
            <object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="230"
                height="280">
                <param name="movie" value="../../App_Themes/Pontao/flasheventos.swf" />
                <param name="quality" value="high" />
                <param name="wmode" value="opaque" />
                <param name="swfversion" value="9.0.45.0" />
                <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
                <param name="expressinstall" value="../../App_Themes/Pontao/Scripts/expressInstall.swf" />
                <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
                <!--[if !IE]>-->
                <object type="application/x-shockwave-flash" data="../../App_Themes/Pontao/flasheventos.swf"
                    width="230" height="280">
                    <!--<![endif]-->
                    <param name="quality" value="high" />
                    <param name="wmode" value="opaque" />
                    <param name="swfversion" value="9.0.45.0" />
                    <param name="expressinstall" value="../../App_Themes/Pontao/Scripts/expressInstall.swf" />
                    <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
                    <div>
                        <h4>
                            Content on this page requires a newer version of Adobe Flash Player.</h4>
                        <p>
                            <a href="http://www.adobe.com/go/getflashplayer">
                                <img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif"
                                    alt="Get Adobe Flash player" width="112" height="33" /></a></p>
                    </div>
                    <!--[if !IE]>-->
                </object>
                <!--<![endif]-->
            </object>
        </div>
        <div id="newsletter">
            <h1>
                <img src="../../App_Themes/Pontao/images/title06.gif" alt="Buscar" /></h1>
            <form id="form3" name="form3" method="post" action="">
            <h2>
                Cadastre-se abaixo para receber no seu e-mail novidades dos pontos de cultura afiliados
                em nosso site.</h2>
            <p>
                <label>
                    <span>Nome:</span><input name="nome" type="text" id="Buscar" value="" size="22" /></label></p>
            <p>
                <label>
                    <span>Email:</span><input name="email" type="text" id="Buscar" value="" size="22" /></label></p>
            <p>
                <input type="image" src="../../App_Themes/Pontao/images/assinar_btn.gif" align="right" /></p>
            </form>
        </div>
    </div>
    <div id="assinatura">
        <h2>
            <a href="#">Sobre o Pont&atilde;o</a> | <a href="#">Galeria</a> | <a href="#">V&iacute;deos</a>
            | <a href="#">Mapa do Site</a> | <a href="#">Fale Conosco</a></h2>
        <p>
            <span>Coordena&ccedil;&atilde;o:<br />
                <img src="../../App_Themes/Pontao/images/logo01.gif" alt="Alonso Oliveira" /></span>
            <span>Patroc&iacute;nio:<br />
                <a href="http://www.fundarpe.pe.gov.br/" target="_blank">
                    <img src="../../App_Themes/Pontao/images/logo02.gif" alt="Fundarpe" /></a><a href="http://www.pe.gov.br/"
                        target="_blank"><img src="../../App_Themes/Pontao/images/logo03.gif" alt="Governo de Pernambuco" /></a></span>
            <span>Realiza&ccedil;&atilde;o:<br />
                <a href="http://www.associacaoreviva.org.br/" target="_blank">
                    <img src="../../App_Themes/Pontao/images/logo04.gif" alt="Associação Reviva" /></a><a
                        href="http://www.cultura.gov.br/cultura_viva/" target="_blank"><img src="../../App_Themes/Pontao/images/logo05.gif"
                            alt="Cultura Viva" /></a><a href="http://www.cultura.gov.br/" target="_blank"><img
                                src="../../App_Themes/Pontao/images/logo06.jpg" alt="Ministério da Cultura" /></a><a
                                    href="http://www.brasil.gov.br/" target="_blank"><img src="../../App_Themes/Pontao/images/logo07.gif"
                                        alt="Governo Federal" /></a></span>
        </p>
        <h2>
            Copyright © 2009 Pont&atilde;o do Canavial. TODOS OS DIREITOS RESERVADOS.</h2>
    </div>
</asp:Content>
