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
    public byte[] ImagemPequena { get; set; }

    [UIHint("ImagemMediaFileUpload")]
    [DisplayName("Imagem com tamanho Médio:")]
    public byte[] ImagemMedia { get; set; }


    [UIHint("ImagemGrandeFileUpload")]
    [DisplayName("Imagem com tamanho Grande:")]
    public byte[] ImagemGrande { get; set; }

    [UIHint("LogoFileUpload")]
    [DisplayName("Logo do Ponto:")]
    public byte[] Logo { get; set; }

}









