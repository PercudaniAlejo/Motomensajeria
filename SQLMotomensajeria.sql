CREATE DATABASE MotoMensajeria;
USE MotoMensajeria;

CREATE TABLE Motoquero(
	id int identity(1,1) primary key NOT NULL,
	nombre varchar(100) NULL,
	apellido varchar(100) NULL,
	numCelular int NOT NULL,
	modeloMoto varchar(100) NULL
)

CREATE TABLE Envio(
	idEnvio int identity(1,1) primary key NOT NULL,
	fecha datetime NOT NULL, 

	nombreCliente varchar(100) NULL,
	apellidoCliente varchar(100) NULL,
	numCelCliente int NOT NULL,


	domicEntrega varchar (100) NULL,
	localidadEntrega varchar(50) NULL,
	unidades int NOT NULL,
	fragil bit NOT NULL,

	idMotoquero int NOT NULL,

	precioViaje float NOT NULL,
	precioFinal float NOT NULL
)

ALTER TABLE Envio ADD CONSTRAINT FK_Envio_idMotoquero FOREIGN KEY (idMotoquero)
REFERENCES Motoquero (id);  
