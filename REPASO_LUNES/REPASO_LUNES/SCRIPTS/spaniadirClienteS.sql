--PROCEDIMIENTOS ALMACENADOS
--CREA UN PROCEDIMIENTO ALMACENADO PARA AÑADIR CLIENTES

CREATE PROCEDURE spañadirClienteS
@IDCLIENTE VARCHAR (5),
@APELLIDOS VARCHAR (30),
@NOMBRES VARCHAR (30)
AS
INSERT INTO CLIENTE (IDCLIENTE, APELLIDOS, NOMBRES) 
VALUES (@IDCLIENTE, @APELLIDOS, @NOMBRES); 

EXEC spañadirClienteS  'K4152', 'FERNANDEZ FERNADEZ', 'MARIO';