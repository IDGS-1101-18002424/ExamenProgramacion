USE SistemaNoticias;
GO

-- Insertar registros en la tabla Personal
INSERT INTO Personal (ApePaterno, ApeMaterno, Nombre, Direccion, FechaDeIngreso) VALUES
('García', 'Lopez', 'Juan', 'Calle 1, Ciudad', '2024-01-15'),
('Hernández', 'Martínez', 'Ana', 'Calle 2, Ciudad', '2024-02-10'),
('Pérez', 'Sánchez', 'Luis', 'Calle 3, Ciudad', '2024-03-05'),
('Ramírez', 'González', 'María', 'Calle 4, Ciudad', '2024-04-20');

-- Insertar registros en la tabla Usuario
INSERT INTO Usuario (Tipo_Usuario, Nombre, Correo, Password) VALUES
('interno', 'Carlos', 'carlos@example.com', 'pass123'),
('externo', 'Laura', 'laura@example.com', 'pass456'),
('interno', 'Miguel', 'miguel@example.com', 'pass789'),
('externo', 'Sofía', 'sofia@example.com', 'pass101');

-- Insertar registros en la tabla Nota
INSERT INTO Nota (Titulo, Contenido, Fecha_Publicacion, IdPersonal) VALUES
('Título 1', 'Contenido de la nota 1', '2024-10-01', 1),
('Título 2', 'Contenido de la nota 2', '2024-10-02', 2),
('Título 3', 'Contenido de la nota 3', '2024-10-03', 3),
('Título 4', 'Contenido de la nota 4', '2024-10-04', 4);

-- Insertar registros en la tabla Comentario
INSERT INTO Comentario (Contenido, Fecha_Comentario, IdNota, IdUsuario, Es_Interno) VALUES
('Comentario sobre la nota 1', '2024-10-05', 1, 1, 1),
('Comentario sobre la nota 2', '2024-10-06', 2, 2, 0),
('Comentario sobre la nota 3', '2024-10-07', 3, 3, 1),
('Comentario sobre la nota 4', '2024-10-08', 4, 4, 0);

-- Insertar registros en la tabla RespuestaComentario
INSERT INTO RespuestaComentario (Contenido, Fecha_Respuesta, IdComentario, IdUsuario) VALUES
('Respuesta al comentario 1', '2024-10-09', 1, 2),
('Respuesta al comentario 2', '2024-10-10', 2, 1),
('Respuesta al comentario 3', '2024-10-11', 3, 4),
('Respuesta al comentario 4', '2024-10-12', 4, 3);
