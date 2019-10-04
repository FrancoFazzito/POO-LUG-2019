create table Cliente(
  codigo_cliente int,
  nombre varchar(30),
  apellido varchar(30),

  primary key(codigo_cliente)
);

create table Telefono(
  codigo_telefono int,
  numero varchar(20),
  codigo_cliente int
  primary key(codigo_telefono) 
);