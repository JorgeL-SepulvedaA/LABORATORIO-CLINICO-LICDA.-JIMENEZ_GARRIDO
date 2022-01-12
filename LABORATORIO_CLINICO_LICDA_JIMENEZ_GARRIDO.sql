create database LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO;

go

use LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO;

go

create table Tipo_Usuarios
(
	Id int identity(0,1) primary key,
	Descripcion varchar(30) not null
);

go

create table Usuarios
(
	Id int identity(0,1) primary key,
	Nombre_Usuario varchar(30) not null,
	Contraseña varchar(30) not null,
	Nombre_Completo varchar(100) not null,
	Correo varchar(100) not null,
	Tipo_Usuario int not null,
	constraint fk_tipo_usuario foreign key (Tipo_Usuario) references Tipo_Usuarios(Id)
);

go

create table Resultados
(
	Id int identity(0,1) primary key,
	Archivo text not null,
	Id_Cliente int not null,
	Id_Auxiliar int not null,
	Fecha_Resultados datetime not null,
	constraint fk_cliente_resultado foreign key (Id_Cliente) references Usuarios(Id),
	constraint fk_auxiliar_resultado foreign key (Id_Auxiliar) references Usuarios(Id)
);

go

insert into Tipo_Usuarios
values 
('Master'), ('Administrador'), ('Auxiliar'), ('Cliente');
go

insert into Usuarios
values 
('master', 'master', 'master', 'testing_tecc@outlook.com', 0), ('admin', '1234', 'administrator', 'testing_tecc@outlook.com', 1),
('aux', '1234', 'auxiliar', 'testing_tecc@outlook.com', 2), ('client', '1234', 'cliente', 'testing_tecc@outlook.com', 3);
go

insert into Resultados
values 
('C:\Users\jorge\Documents\GitHub\LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO\family.png', 3, 2, 2021-10-16);
go