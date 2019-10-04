create database PersonaBD;
use PersonaBD;
create table Persona(
	codigo int,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	primary key(codigo)
);
drop table Persona;