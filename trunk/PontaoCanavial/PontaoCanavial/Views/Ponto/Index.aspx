<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Models.VOs" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Pont&atilde;o do Canavial</title>
    <link href="../../App_Themes/Pontao/CSS/style_pontao.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="root">
        <div id="top">
            <a href="#">
                <%=Html.Image("imgLogo", "../../App_Themes/Pontao/images/pontao_logo.gif", "Logo do Pontão do Canavial")%></a>
            <%=Html.Image("imgBanner", "../../App_Themes/Pontao/images/pontao_banner.jpg", "")%>
        </div>
        <div id="menu-1">
            <%=Html.Image("imgPontos", "../../App_Themes/Pontao/images/pontao_bar.jpg", "Pontos de Cultura")%>
            <ul>
                <li>
                    <p>
                        <a href="#">Pont&atilde;o</a></p>
                </li>
                <li>
                    <p>
                        <a href="#">Not&iacute;cias</a></p>
                </li>
                <li>
                    <p>
                        <a href="#">Eventos</a></p>
                </li>
                <li>
                    <p>
                        <a href="#">Galerias</a></p>
                </li>
                <li>
                    <p>
                        <a href="#">V&iacute;deos</a></p>
                </li>
                <li>
                    <p>
                        <a href="#">Produtos</a></p>
                </li>
                <li>
                    <p>
                        <a href="#">Contatos</a></p>
                </li>
            </ul>
        </div>
        <div id="content">
            <div id="coluna-1">
                <ul>
                    <li><a href="#">Alafi&aacute;</a></li>
                    <li><a href="#">Boi da Macuca</a></li>
                    <li><a href="#">Casar&atilde;o de Of&iacute;cios</a></li>
                    <li><a href="#">Cinema de Anima&ccedil;&atilde;o</a></li>
                    <li><a href="#">Engenho dos Maracatus</a></li>
                    <li><a href="#">Estrela de Ouro</a></li>
                    <li><a href="#">Ororub&aacute;</a></li>
                    <li><a href="#">Po&ccedil;o Comprido</a></li>
                    <li><a href="#">Retretas</a></li>
                </ul>
                <%=Html.Image("imgMenuBottom", "../../App_Themes/Pontao/images/menu2_bottom.gif", "")%>
            </div>
            <div id="coluna-2">
                <div id="eventos">
                    <%=Html.Image("imgEventos", "../../App_Themes/Pontao/images/pontao_eventos.gif", "Eventos do Pont&atilde;o")%>
                </div>
                <div id="noticias">
                    <h1>
                        <%=Html.Image("imgNoticias", "../../App_Themes/Pontao/images/title02.gif", "Not&iacute;cias")%>
                    </h1>
                    <ul>
                        <li>
                            <h2>
                                Lorem ipsum dolor</h2>
                            <h3>
                                14.09.2009</h3>
                            <a href="#"><span>
                                <%=Html.Image("imgFoto1", "../../App_Themes/Pontao/images/foto_not1.jpg", "foto")%>
                                <p>
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
                                <%=Html.Image("imgFoto2", "../../App_Themes/Pontao/images/foto_not2.jpg", "foto")%>
                                <p>
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
                                <%=Html.Image("imgFoto3", "../../App_Themes/Pontao/images/foto_not3.jpg", "foto")%>
                                <p>
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
                                <%=Html.Image("imgFoto4", "../../App_Themes/Pontao/images/foto_not4.jpg", "foto")%>
                                <p>
                                    Donec eu purus eu quam blandit blandit nec nec turpis. Vestibulum ante ipsum primis
                                    in faucibus.
                                </p>
                            </span></a></li>
                    </ul>
                </div>
                <div id="galerias">
                    <h1>
                        <%=Html.Image("imgGalerias", "../../App_Themes/Pontao/images/title04.gif", "Galerias")%>
                    </h1>
                    <ul>
                        <li>
                            <h2>
                                Lorem ipsum dolor</h2>
                            <a href="#"><span>
                                <%=Html.Image("imgFoto5", "../../App_Themes/Pontao/images/foto_gal1.jpg", "foto")%>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut at libero sagittis vitae
                                    scelerisque nibh. Nulla.
                                </p>
                            </span></a></li>
                        <li>
                            <h2>
                                Vivamus vel tellus</h2>
                            <a href="#"><span>
                                <%=Html.Image("imgFoto6", "../../App_Themes/Pontao/images/foto_gal2.jpg", "foto")%>
                                <p>
                                    Vivamus vel tellus purus, non sollicitudin lacus. Aliquam ut ultricies lorem.
                                </p>
                            </span></a></li>
                    </ul>
                </div>
                <div id="produtos">
                    <h1>
                        <%=Html.Image("imgProdutos", "../../App_Themes/Pontao/images/title05.gif", "Produtos")%>
                    </h1>
                    <ul>
                        <li><a href="#"><span>
                            <%=Html.Image("imgFoto7", "../../App_Themes/Pontao/images/foto_pro1.jpg", "foto")%>
                            <h2>
                                Maracatu Estrela de Ouro de Alian&ccedil;a: a saga de uma tradi&ccedil;&atilde;o</h2>
                            <p>
                                Severino Vicente</p>
                        </span></a></li>
                        <li><a href="#"><span>
                            <%=Html.Image("imgFoto8", "../../App_Themes/Pontao/images/foto_pro2.jpg", "foto")%>
                            <h2>
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
                        <%=Html.Image("imgBuscar", "../../App_Themes/Pontao/images/title01.jpg", "Buscar")%>
                    </h1>
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
                <div id="enquete">
                    <h1>
                        <%=Html.Image("imgBuscar2", "../../App_Themes/Pontao/images/title03.jpg", "Buscar")%>
                    </h1>
                    <form id="form2" name="form2" method="post" action="">
                    <h2>
                        Duis sit amet sem massa, nec porttitor nunc. Nullam varius venenatis semper?</h2>
                    <ul>
                        <li>
                            <label>
                                <input name="radio" type="radio" id="enquete1" value="enquete" checked="checked" />
                                Nullam pharetra
                            </label>
                        </li>
                        <li>
                            <label>
                                <input name="radio" type="radio" id="enquete2" value="enquete" />
                                Leo pulvinar
                            </label>
                        </li>
                        <li>
                            <label>
                                <input name="radio" type="radio" id="enquete3" value="enquete" />
                                Mattis eget
                            </label>
                        </li>
                        <li>
                            <label>
                                <input name="radio" type="radio" id="enquete4" value="enquete" />
                                Lorem ipsum
                            </label>
                        </li>
                        <li>
                            <label>
                                <input name="radio" type="radio" id="enquete5" value="enquete" />
                                Porro quisquam
                            </label>
                        </li>
                    </ul>
                    <p>
                        <input type="image" src="../../App_Themes/Pontao/images/votar_btn.gif" align="right" /></p>
                    </form>
                </div>
                <div id="newsletter">
                    <h1>
                        <%=Html.Image("imgBuscar3", "../../App_Themes/Pontao/images/title06.jpg", "Buscar")%>
                    </h1>
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
       	  <h2><a href="#">Sobre o Pontão</a> |  <a href="#">Galeria</a> |  <a href="#">Vídeos</a> |  <a href="#">Mapa do Site</a> |  <a href="#">Fale Conosco</a></h2>
            <p>
            <span>Coordenação:<br/><%=Html.Image("imgAlonsoOliveira","../../App_Themes/Pontao/images/logo01.gif","Alonso Oliveira") %></span>
            <span>Patrocínio:<br/><%=Html.Image("imgFundarpe","../../App_Themes/Pontao/images/logo02.gif","FUNDARPE") %> <%=Html.Image("imgGovernoEstado","../../App_Themes/Pontao/images/logo03.gif","Governo do Estado") %></span>
            <span>Realização:<br/>
            <%=Html.Image("imgReviva", "../../App_Themes/Pontao/images/logo04.gif", "Associação Reviva")%> <%=Html.Image("imgCulturaViva", "../../App_Themes/Pontao/images/logo05.gif", "Cultura Viva")%> <%=Html.Image("imgMinisterioCultura", "../../App_Themes/Pontao/images/logo06.jpg", "Ministério da Cultura")%> <%=Html.Image("imgGovernoFederal", "../../App_Themes/Pontao/images/logo07.gif", "Governo Federal")%></span>
            </p>
            <h2>Copyright © 2009 Pontão do Canavial. TODOS OS DIREITOS RESERVADOS.</h2>
          </div>
      </div>
    </div>
</body>
</html>
