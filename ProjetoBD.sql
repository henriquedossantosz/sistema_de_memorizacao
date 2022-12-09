create database projetoHenrique
use projetoHenrique;

create table Usuarios
(
	id int identity(1,1) primary key not null,
	Nome varchar(50),
	Email varchar(50),
	Celular varchar(11),
	CPF varchar(11),
	Nascimento datetime,
	NomeUsuario varchar(50),
	Senha varchar(50)
)

create table Idioma
(
	Codigo_Idioma int identity(1,1) primary key,
	Nome_Idioma varchar(20)
	FK_Codigo_Estudante int foreign key references Usuarios(id) 
)

create table Palavra
(
	Codigo_Palavra int identity(1,1) primary key,
  	Palavra_Texto nvarchar(30),
	Definicao varchar(30),
  	Palavra_Pronuncia nvarchar(30),
  	Palavra_Animo int,
  	Palavra_Utilidade int,
	Classificacao varchar(8),
  	Morfologia varchar(20),
  	Fonte varchar(20),
	Tema varchar(30),
  	Observacao varchar(20),
  	FK_Codigo_Idioma int foreign key references Idioma(Codigo_Idioma)
)

create table Conjunto_de_Revisao
(
	Codigo_CR int identity(1,1) primary key,
  	Nome_CR varchar(30),
  	Descricao varchar(50),
	FK_Codigo_Idioma int foreign key references Idioma(Codigo_Idioma)
)

create table FlashCard
(
	id int identity(1,1) primary key not null,
	frente nvarchar(30),
	verso nvarchar(30),
	criacao datetime,
	poxrevisao datetime,
	acerto int,
	erro int,
	adddias int,
	FK_Codido_CR int foreign key references Conjunto_de_Revisao(Codigo_CR)
)