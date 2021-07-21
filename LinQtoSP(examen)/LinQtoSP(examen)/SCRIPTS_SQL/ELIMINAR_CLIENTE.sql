--para eliminar clientes
CREATE PROCEDURE EliminarCliente
@Nombre varchar (50)
AS
DELETE FROM Clientes 
WHERE @Nombre=Nombre

EXEC EliminarCliente 'PEPE';