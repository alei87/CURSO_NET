--PROCEDIMIENTO ALMACENADO PARA MODIFICAR UN CLIENTE
CREATE PROCEDURE spModificarCliente
@IDCLIENTE VARCHAR (5),
@APELLIDOS VARCHAR (30),
@NOMBRES VARCHAR (30)
AS
UPDATE CLIENTE
SET
APELLIDOS=@APELLIDOS,
NOMBRES= @NOMBRES
WHERE IDCLIENTE=@IDCLIENTE;

EXEC spModificarCliente 'K4152', 'FERNANDEZ FERNADEZ', 'MARIA' ;