
CREATE TABLE Ponto (
  Id int  NOT NULL primary key identity,
  Nome varchar(50) DEFAULT NULL,
  NomeIdentificador varchar(20) DEFAULT NULL,
  DescricaoOficina varchar(8000) DEFAULT NULL,
  ImagemOficina image null,
  ApresentacaoProjeto varchar(8000) DEFAULT NULL,
  ObjetivoProjeto varchar(8000) DEFAULT NULL,
  EquipeProjeto varchar(8000) DEFAULT NULL,
  JustificativaProjeto varchar(8000) DEFAULT NULL,
  EPontao bit DEFAULT NULL
);

CREATE TABLE Banner (
  Id int  NOT NULL primary key identity,
  PontoId int  NOT NULL,
  Nome varchar(255) DEFAULT NULL,
  StatusBanner int  DEFAULT NULL,
  Localizacao int  DEFAULT NULL,
  Corpo Image null
  
);

ALTER TABLE Banner 
ADD Foreign Key (PontoId) REFERENCES Ponto(Id);

CREATE TABLE Categoria (
  Id int  NOT NULL primary key identity,
  Descricao varchar(20) DEFAULT NULL
);

CREATE TABLE Galeria (
  Id int  NOT NULL primary key identity,
  PontoId int  NOT NULL,
  Nome varchar(255) DEFAULT NULL,
  Descricao varchar(255) DEFAULT NULL
  
);

ALTER TABLE Galeria 
ADD Foreign Key (PontoId) REFERENCES Ponto(Id);

CREATE TABLE Imagem (
  Id int  NOT NULL primary key identity,
  GaleriaId int  NOT NULL,
  Nome varchar(50) DEFAULT NULL,
  Descricao varchar(255) DEFAULT NULL,
  Pequena Image null,
  Media Image null,
  Grande Image null 
);


ALTER TABLE Imagem 
ADD Foreign Key (GaleriaId) REFERENCES Galeria(Id);

CREATE TABLE Newsletter (
  Id int  NOT NULL primary key identity,
  PontoId int  NOT NULL,
  Email varchar(50) DEFAULT NULL 
);

ALTER TABLE Newsletter 
ADD Foreign Key (PontoId) REFERENCES Ponto(Id);

CREATE TABLE Noticia (
  Id int  NOT NULL primary key identity,
  PontoId int  NOT NULL,
  Titulo varchar(255) DEFAULT NULL,
  DataCriacao datetime DEFAULT NULL,
  Preview varchar(255) DEFAULT NULL,
  Corpo varchar(8000) DEFAULT NULL,
  Imagem Image null
);

ALTER TABLE Noticia 
ADD Foreign Key (PontoId) REFERENCES Ponto(Id);

CREATE TABLE Produto (
  Id int  NOT NULL primary key identity,
  PontoId int  NOT NULL,
  CategoriaId int  NOT NULL,
  Nome varchar(50) DEFAULT NULL,
  Imagem int  DEFAULT NULL,
  Descricao int  DEFAULT NULL
);

ALTER TABLE Produto 
ADD Foreign Key (PontoId) REFERENCES Ponto(Id);

ALTER TABLE Produto 
ADD Foreign Key (CategoriaId) REFERENCES Categoria(Id);

CREATE TABLE Usuario (
  Id int  NOT NULL primary key identity,
  Nome varchar(50) DEFAULT NULL,
  Email varchar(25) DEFAULT NULL,
  Senha varchar(25) DEFAULT NULL,
  Telefone varchar(15) DEFAULT NULL
);

CREATE TABLE UsuarioPonto (
Id int NOT NULL primary key identity,
  PontoId int  NOT NULL,
  UsuarioId int  NOT NULL
  
);

ALTER TABLE UsuarioPonto 
ADD Foreign Key (PontoId) REFERENCES Ponto(Id);

ALTER TABLE UsuarioPonto 
ADD Foreign Key (UsuarioId) REFERENCES Usuario(Id);

