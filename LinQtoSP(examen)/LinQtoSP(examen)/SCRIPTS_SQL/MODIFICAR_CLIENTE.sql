--PARA MODIFICAR CLIENTES
CREATE PROCEDURE Modificarcliente
@Nombre varchar (50),
@Apellido1 varchar (50),
@Apellido2 varchar (50),
@Telefono varchar (50)
AS
UPDATE Clientes 
SET Nombre=@Nombre, Apellido1 =@Apellido1, Apellido2=@Apellido2, Telefono= @Telefono
WHERE Nombre=@Nombre

EXEC Modificarcliente 'PEPE', 'GANDALF', 'EL GRIS', 'XXXXXXX';
