-- Creación de la base de datos
/*CREATE DATABASE SistemaNoticias;
GO*/

USE SistemaNoticias;
GO

CREATE TABLE Personal (
    IdPersonal INT PRIMARY KEY IDENTITY,
    ApePaterno VARCHAR(60) NOT NULL,
    ApeMaterno VARCHAR(60) NOT NULL,
    Nombre VARCHAR(60) NOT NULL,
    Direccion VARCHAR(100) NOT NULL,
    FechaDeIngreso DATE NOT NULL
);

CREATE TABLE Usuario (
    IdUsuario INT PRIMARY KEY IDENTITY,
    Tipo_Usuario VARCHAR(10) CHECK (Tipo_Usuario IN ('interno', 'externo')) NOT NULL,
    Nombre VARCHAR(60) NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    Password VARCHAR(60) NOT NULL
);

CREATE TABLE Nota (
    IdNota INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(100) NOT NULL,
    Contenido TEXT NOT NULL,
    Fecha_Publicacion DATETIME NOT NULL,
    IdPersonal INT NOT NULL,
    FOREIGN KEY (IdPersonal) REFERENCES Personal(IdPersonal)
);

CREATE TABLE Comentario (
    IdComentario INT PRIMARY KEY IDENTITY,
    Contenido TEXT NOT NULL,
    Fecha_Comentario DATETIME NOT NULL,
    IdNota INT NOT NULL,
    IdUsuario INT NOT NULL,
    Es_Interno BIT NOT NULL,
    FOREIGN KEY (IdNota) REFERENCES Nota(IdNota),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);

CREATE TABLE RespuestaComentario (
    IdRespuesta INT PRIMARY KEY IDENTITY,
    Contenido TEXT NOT NULL,
    Fecha_Respuesta DATETIME NOT NULL,
    IdComentario INT NOT NULL,
    IdUsuario INT NOT NULL,
    FOREIGN KEY (IdComentario) REFERENCES Comentario(IdComentario),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);
