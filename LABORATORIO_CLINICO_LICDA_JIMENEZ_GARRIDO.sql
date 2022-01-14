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
	Contrase�a varchar(30) not null,
	Nombre_Completo varchar(100) not null,
	Correo varchar(100) not null,
	Tipo_Usuario int not null,
	constraint fk_tipo_usuario foreign key (Tipo_Usuario) references Tipo_Usuarios(Id)
);

go

create table Tipo_Resultados
(
	Id int identity(0,1) primary key,
	Descripcion varchar(30) not null
);

go

create table Resultados
(
	Id int identity(0,1) primary key,
	Archivo text null,
	Id_Cliente int not null,
	Id_Auxiliar int not null,
	Fecha_Resultados datetime null,
	Tipo_Resultado int null,
	constraint fk_cliente_resultado foreign key (Id_Cliente) references Usuarios(Id),
	constraint fk_auxiliar_resultado foreign key (Id_Auxiliar) references Usuarios(Id),
	constraint fk_tipo_resultado foreign key (Tipo_Resultado) references Tipo_Resultados(Id)
);

go

insert into Tipo_Usuarios
values 
('MasterA'), ('MasterB'), ('Administrador'), ('Auxiliar'), ('Cliente');
go

insert into Usuarios
values 
('master', 'mastera', 'masterA', 'testing_tecc@outlook.com', 0), ('master', 'masterb', 'masterB', 'testing_tecc@outlook.com', 1), ('admin', '1234', 'administrator', 'testing_tecc@outlook.com', 2),
('aux', '1234', 'auxiliar', 'testing_tecc@outlook.com', 3), ('client', '1234', 'cliente', 'testing_tecc@outlook.com', 4);
go

insert into Tipo_Resultados
values 
('PRUEBA ANTIGENO'), ('PRUEBA PCR'), ('PRUEBA ANTICUERPO');
go

insert into Resultados
values 
('C:\Users\jorge\Documents\GitHub\LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO\PCR_REPORT_NICOLE_ELISA_NOBLE.pdf', 3, 2, 2021-10-16, 0),
('C:\Users\jorge\Documents\GitHub\LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO\PCR_REPORT_NICOLE_ELISA_NOBLE.pdf', 3, 2, 2021-10-17, 1),
('C:\Users\jorge\Documents\GitHub\LABORATORIO_CLINICO_LICDA_JIMENEZ_GARRIDO\PCR_REPORT_NICOLE_ELISA_NOBLE.pdf', 3, 2, 2021-10-18, 2);
go

/*truncate table Resultados
drop table Resultados
go

truncate table Tipo_Resultados
drop table Tipo_Resultados
go

truncate table Usuarios
drop table Usuarios
go

truncate table Tipo_Usuarios
drop table Tipo_Usuarios
go*/

/*select * from Tipo_Resultados
update Tipo_Resultados set Descripcion = 'PRUEBA PCR' where Id = 2*/