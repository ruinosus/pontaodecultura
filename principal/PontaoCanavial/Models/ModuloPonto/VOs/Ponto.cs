using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web.Mvc;
using PontaoCanavial.Models.ModuloBasico.VOs;
using PontaoCanavial.Models.ModuloPonto.Repositorios;
using PontaoCanavial.Models.ModuloBasico.Enums;
using System.ComponentModel;

[MetadataType(typeof(PontoMetadata))]
public partial class Ponto
{
    
    
}

/* Exemplo de formulário

//--------------------------------------
//Bloco referente a validação via Ciente	
<script src="/Scripts/MicrosoftAjax.js" type="text/javascript" > </script>
<script src="/Scripts/MicrosoftMvcValidation.js" type="text/javascript" > </script>

<% Html.EnableClientValidation(); %>
//--------------------------------------
	
	<%Html.ValidationSummary("Corrija os erros e tente novamente.") %>
	<%
	using (html.BeginForm() ) 
		{
	%>
			<fieldset>
				<%= html.LabelFor(model => model.Nome)%>
				<%= html.TextBoxFor(model => model.Nome)%>
				<%= html.ValidationMessageFor(model => model.Nome,"*")%>

				<input type="submit" value="create"/>
			</fieldset>
	<%
		}
	%>
*/

/* Exemplo de Controller
	[HttpPost]
	public ActionResult Create(Ponto ponto)
	{
		if(ModelState.IsValid)
		{
			//Salvar o ponto aki
			return Redirect("/");
		}
		//Invalido - volta a tela mostrando os erros contidos.
		return View(ponto);

	}


*/
[Bind(Exclude = "ID")]
public class PontoMetadata
{
    [Required(ErrorMessage = "O nome do Ponto é Necessário para o cadastro.")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O nome identificador do Ponto é Necessário para o cadastro.")]
    [DisplayName("Nome Identificador do Ponto:")]
    public string NomeIdentificador { get; set; }
   
    [UIHint("ImagemPequenaFileUpload")]
    [DisplayName("Imagem com tamanho Pequeno:")]
    public Byte[] ImagemPequena { get; set; }

    [UIHint("ImagemMediaFileUpload")]
    [DisplayName("Imagem com tamanho Médio:")]
    public Byte[] ImagemMedia { get; set; }


    [UIHint("ImagemGrandeFileUpload")]
    [DisplayName("Imagem com tamanho Grande:")]
    public Byte[] ImagemGrande { get; set; }

    [UIHint("LogoFileUpload")]
    [DisplayName("Logo do Ponto:")]
    public Byte[] Logo { get; set; }

}

/* - Cria um formulário contendo todos os campos contidos no Model.

<%Html.ValidationSummary("Corrija os erros e tente novamente.") %>
   <%
   using (html.BeginForm() ) 
       {
   %>
           <fieldset>
               <%= html.EditorFor(c=>c)%>

               <input type="submit" value="create"/>
           </fieldset>
   <%
       }
   %>


*/
/*
    [DisplayName("Exemplo de exibição:")]
	[UIHint("DropListTeste")]
	public string Teste{get;set;}

    //[ScaffoldColumn(false)] - não mostra a propriedade

*/



/*


você pode agora opcionalmente adicionar uma pasta chamada "EditorTemplates” e/ou “DisplayTemplates” abaixo do diretório \Views\[controllername] (se você quiser customizar a renderização das visões usadas por um controlador específico) ou abaixo do diretório \Views\Shared (se você quiser customizar a renderização de todas as visões e controladores em uma aplicação).


*/