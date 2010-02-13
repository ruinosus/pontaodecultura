using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;



[MetadataType(typeof(UsuarioMetadata))]
public partial class Usuario
{
    

}

[Bind(Exclude = "ID")]
public class UsuarioMetadata
{
    [Required(ErrorMessage = "O nome do Usuário é Necessário para o cadastro.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Login do Usuário é Necessário para o cadastro.")]
    public string Login { get; set; }

    [Required(ErrorMessage = "A Senha do Usuário é Necessário para o cadastro.")]
    public string Senha { get; set; }
    

}

