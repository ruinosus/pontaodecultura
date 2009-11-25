<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Ponto/MasterPagePontinho.Master"
    Inherits="System.Web.Mvc.ViewPage<PontaoCanavial.Controllers.PontoFormViewModel>" %>

<%@ Import Namespace="PontaoCanavial.Models.VOs" %>
<%@ Import Namespace="PontaoCanavial.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentMasterPontinho" runat="server">
    <div id="coluna-2">
        <div id="eventos">
            <img src="../../App_Themes/Pontinho/images/pontao_eventos.gif" alt="Eventos do Pont&atilde;o" />
        </div>
        <div id="noticias">
            <h1>
                <img src="../../App_Themes/Pontinho/images/title02.gif" alt="Not&iacute;cias" /></h1>
            <ul>
                <li>
                    <h2>
                        Lorem ipsum dolor</h2>
                    <h3>
                        14.09.2009</h3>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontinho/images/foto_not1.jpg" alt="foto" /><p>
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
                        <img src="../../App_Themes/Pontinho/images/foto_not2.jpg" alt="foto" /><p>
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
                        <img src="../../App_Themes/Pontinho/images/foto_not3.jpg" alt="foto" /><p>
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
                        <img src="../../App_Themes/Pontinho/images/foto_not4.jpg" alt="foto" /><p>
                            Donec eu purus eu quam blandit blandit nec nec turpis. Vestibulum ante ipsum primis
                            in faucibus.
                        </p>
                    </span></a></li>
            </ul>
        </div>
        <div id="galerias">
            <h1>
                <img src="../../App_Themes/Pontinho/images/title04.gif" alt="Galerias" /></h1>
            <ul>
                <li>
                    <h2>
                        Lorem ipsum dolor</h2>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontinho/images/foto_gal1.jpg" alt="foto" /><p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut at libero sagittis vitae
                            scelerisque nibh. Nulla.
                        </p>
                    </span></a></li>
                <li>
                    <h2>
                        Vivamus vel tellus</h2>
                    <a href="#"><span>
                        <img src="../../App_Themes/Pontinho/images/foto_gal2.jpg" alt="foto" /><p>
                            Vivamus vel tellus purus, non sollicitudin lacus. Aliquam ut ultricies lorem.
                        </p>
                    </span></a></li>
            </ul>
        </div>
        <div id="produtos">
            <h1>
                <img src="../../App_Themes/Pontinho/images/title05.gif" alt="Produtos" /></h1>
            <ul>
                <li><a href="#"><span>
                    <img src="../../App_Themes/Pontinho/images/foto_pro1.jpg" alt="foto" /><h2>
                        Maracatu Estrela de Ouro de Alian&ccedil;a: a saga de uma tradi&ccedil;&atilde;o</h2>
                    <p>
                        Severino Vicente</p>
                </span></a></li>
                <li><a href="#"><span>
                    <img src="../../App_Themes/Pontinho/images/foto_pro2.jpg" alt="foto" /><h2>
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
                <img src="../../App_Themes/Pontinho/images/title01.gif" alt="Buscar" /></h1>
            <form id="form1" name="form1" method="post" action="">
            <p>
                <label>
                    <input name="Buscar" type="text" id="Buscar" value="Buscar" /></label></p>
            <p>
                <label>
                    <select name="diretorio" id="diretorio">
                        <option>No Pontão do Canavial</option>
                        <option selected="selected">No Alafiá</option>
                        <option>No Boi de Macuca</option>
                        <option>No Cinema de Animação</option>
                        <option>No Engenho dos Maracatus</option>
                        <option>No Estrela de Ouro</option>
                        <option>No Ororubá</option>
                        <option>No Poço Comprido</option>
                        <option>No Retretas</option>
                    </select></label></p>
            <p>
                <input type="image" src="../../App_Themes/Pontinho/images/buscar_btn.gif" align="right" /></p>
            </form>
        </div>
        <div id="enquete">
            <h1>
                <img src="../../App_Themes/Pontinho/images/title03.gif" alt="Buscar" /></h1>
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
                <input type="image" src="../../App_Themes/Pontinho/images/votar_btn.gif" align="right" /></p>
            </form>
        </div>
        <div id="newsletter">
            <h1>
                <img src="../../App_Themes/Pontinho/images/title06.gif" alt="Buscar" /></h1>
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
                <input type="image" src="../../App_Themes/Pontinho/images/assinar_btn.gif" align="right" /></p>
            </form>
        </div>
    </div>
</asp:Content>
