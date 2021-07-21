--PARA INSERTAR CLIENTE
CREATE PROCEDURE insertarcliente
@Nombre varchar (50),
@Apellido1 varchar (50),
@Apellido2 varchar (50),
@Telefono varchar (50)
AS
INSERT INTO Clientes (Nombre, Apellido1, Apellido2, Telefono)
VALUES (@Nombre, @Apellido1, @Apellido2, @Telefono)
GO

EXEC insertarcliente 'PEPE', 'PEREZ', 'PERNIA', '443223343';


