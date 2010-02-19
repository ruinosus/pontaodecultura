﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;
[MetadataType(typeof(ImagemMetadata))]
public partial class Imagem
{


}

[Bind(Exclude = "ID")]
public class ImagemMetadata
{
    [Required(ErrorMessage = "O Nome da Imagem é Necessário para o cadastro.")]
    public string Nome { get; set; }


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

