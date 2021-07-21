--PARA BUSCAR CLIENTES
CREATE PROCEDURE buscarcliente
@Nombre varchar (50)
AS
SELECT *
FROM Clientes
WHERE Nombre like '%' +@Nombre+'%'

EXEC buscarcliente 'PEPE'