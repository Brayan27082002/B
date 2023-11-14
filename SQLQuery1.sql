create database sistema

use sistema 

CREATE TABLE Usuarios (
    ID INT PRIMARY KEY,
    NombreUsuario VARCHAR(50),
    ClaveCifrada VARCHAR(60),
    Estado CHAR(1)
);

CREATE TABLE IntentosFallidos (
    ID INT PRIMARY KEY,
    UsuarioID INT,
    FechaIntento DATETIME,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID)
);

CREATE TABLE ConfiguracionEmpresa (
    ID INT PRIMARY KEY,
    NombreEmpresa VARCHAR(100)
);

select * from Usuarios
select * from IntentosFallidos
select * from ConfiguracionEmpresa

INSERT INTO Usuarios (NombreUsuario, ClaveCifrada, Estado, id)
VALUES ('julian01', 'julian12', 'h', '01'),
       ('brayan01', 'brayan27', 'h', '02'),
	   ('katy01', ' katy14', 'h', '03');

INSERT INTO IntentosFallidos (UsuarioID, FechaIntento, ID)
VALUES (01,GETDATE(), '010'),
       (02,GETDATE(), '020'),
       (03,GETDATE(), '030');


INSERT INTO ConfiguracionEmpresa (NombreEmpresa, id) values
('Ws', '01');

-- codigo para los intentos fallidos--

CREATE PROCEDURE BloquearUsuarioSiNecesario(@UsuarioID INT)
AS
BEGIN
    DECLARE @IntentosFallidos INT;
    SELECT @IntentosFallidos = COUNT(*) FROM IntentosFallidos WHERE UsuarioID = @UsuarioID;
    
    IF @IntentosFallidos >= 3
    BEGIN
        UPDATE Usuarios SET Estado = 'B' WHERE ID = @UsuarioID;
    END
END;
