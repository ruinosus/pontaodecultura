using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

[MetadataType(typeof(ProjetoMetadata))]
public partial class Projeto
{


}

[Bind(Exclude = "ID")]
public class ProjetoMetadata
{
    [Required(ErrorMessage = "A Descricao do Projeto é Necessário para o cadastro.")]
    public string Descricao { get; set; }


    [UIHint("ImagemPequenaFileUpload")]
    [DisplayName("Imagem com tamanho Pequeno:")]
    public byte[] ImagemPequena { get; set; }

    [UIHint("ImagemMediaFileUpload")]
    [DisplayName("Imagem com tamanho Médio:")]
    public byte[] ImagemMedia { get; set; }


    [UIHint("ImagemGrandeFileUpload")]
    [DisplayName("Imagem com tamanho Grande:")]
    public byte[] ImagemGrande { get; set; }


}