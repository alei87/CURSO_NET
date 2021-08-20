
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/20/2021 17:13:14
-- Generated from EDMX file: C:\Users\AsataTarde\Desktop\CURSONET\alei87\CURSO_NET\ModelFirst2\ModelFirst2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PuestoSet'
CREATE TABLE [dbo].[PuestoSet] (
    [Id_Puesto] int IDENTITY(1,1) NOT NULL,
    [Nombre_Puesto] nvarchar(max)  NOT NULL,
    [Id_Nivel_Riesgo] int  NOT NULL,
    [Nivel_Salario_Min] float  NOT NULL,
    [Nivel_Salario_Max] float  NOT NULL
);
GO

-- Creating table 'Registro_transaccion_deduccionSet'
CREATE TABLE [dbo].[Registro_transaccion_deduccionSet] (
    [Id_Transaccion_deduccion] int IDENTITY(1,1) NOT NULL,
    [Id_Empleado] int  NOT NULL,
    [Id_Tipo_Deducc] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Monto] float  NOT NULL
);
GO

-- Creating table 'EmpleadoSet'
CREATE TABLE [dbo].[EmpleadoSet] (
    [Id_Empleado] int IDENTITY(1,1) NOT NULL,
    [Cod_Empleado] nvarchar(max)  NOT NULL,
    [Cedula_Empleado] nvarchar(max)  NOT NULL,
    [Nombre_Empleado] nvarchar(max)  NOT NULL,
    [Id_Departamento] int  NOT NULL,
    [Id_Puesto] int  NOT NULL,
    [Salario_Mensual_Empleado] float  NOT NULL,
    [Responsable_Area] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DepartamentoSet'
CREATE TABLE [dbo].[DepartamentoSet] (
    [Id_Departamento] int IDENTITY(1,1) NOT NULL,
    [Nombre_Departamento] nvarchar(max)  NOT NULL,
    [Ubicacion_Fisica_departamento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tipo_de_DeduccionSet'
CREATE TABLE [dbo].[Tipo_de_DeduccionSet] (
    [Id_Tipo_Deduccion] int IDENTITY(1,1) NOT NULL,
    [Nombre_Tipo_Deduccion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tipo_de_IngresoSet'
CREATE TABLE [dbo].[Tipo_de_IngresoSet] (
    [Id_Tipo_Ingreso] int IDENTITY(1,1) NOT NULL,
    [Nombre_Tipo_Ingreso] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Registro_TransaccionSet'
CREATE TABLE [dbo].[Registro_TransaccionSet] (
    [Id_Transaccion_Ingreso] int IDENTITY(1,1) NOT NULL,
    [Id_Empleado] int  NOT NULL,
    [Id_Tipo_Ingreso] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Monto] float  NOT NULL
);
GO

-- Creating table 'Nivel_RiesgoSet'
CREATE TABLE [dbo].[Nivel_RiesgoSet] (
    [Id_nivel_Riesgo] int IDENTITY(1,1) NOT NULL,
    [Tipo_Riesgo] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Puesto] in table 'PuestoSet'
ALTER TABLE [dbo].[PuestoSet]
ADD CONSTRAINT [PK_PuestoSet]
    PRIMARY KEY CLUSTERED ([Id_Puesto] ASC);
GO

-- Creating primary key on [Id_Transaccion_deduccion] in table 'Registro_transaccion_deduccionSet'
ALTER TABLE [dbo].[Registro_transaccion_deduccionSet]
ADD CONSTRAINT [PK_Registro_transaccion_deduccionSet]
    PRIMARY KEY CLUSTERED ([Id_Transaccion_deduccion] ASC);
GO

-- Creating primary key on [Id_Empleado] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [PK_EmpleadoSet]
    PRIMARY KEY CLUSTERED ([Id_Empleado] ASC);
GO

-- Creating primary key on [Id_Departamento] in table 'DepartamentoSet'
ALTER TABLE [dbo].[DepartamentoSet]
ADD CONSTRAINT [PK_DepartamentoSet]
    PRIMARY KEY CLUSTERED ([Id_Departamento] ASC);
GO

-- Creating primary key on [Id_Tipo_Deduccion] in table 'Tipo_de_DeduccionSet'
ALTER TABLE [dbo].[Tipo_de_DeduccionSet]
ADD CONSTRAINT [PK_Tipo_de_DeduccionSet]
    PRIMARY KEY CLUSTERED ([Id_Tipo_Deduccion] ASC);
GO

-- Creating primary key on [Id_Tipo_Ingreso] in table 'Tipo_de_IngresoSet'
ALTER TABLE [dbo].[Tipo_de_IngresoSet]
ADD CONSTRAINT [PK_Tipo_de_IngresoSet]
    PRIMARY KEY CLUSTERED ([Id_Tipo_Ingreso] ASC);
GO

-- Creating primary key on [Id_Transaccion_Ingreso] in table 'Registro_TransaccionSet'
ALTER TABLE [dbo].[Registro_TransaccionSet]
ADD CONSTRAINT [PK_Registro_TransaccionSet]
    PRIMARY KEY CLUSTERED ([Id_Transaccion_Ingreso] ASC);
GO

-- Creating primary key on [Id_nivel_Riesgo] in table 'Nivel_RiesgoSet'
ALTER TABLE [dbo].[Nivel_RiesgoSet]
ADD CONSTRAINT [PK_Nivel_RiesgoSet]
    PRIMARY KEY CLUSTERED ([Id_nivel_Riesgo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_Nivel_Riesgo] in table 'PuestoSet'
ALTER TABLE [dbo].[PuestoSet]
ADD CONSTRAINT [FK_Nivel_RiesgoPuesto]
    FOREIGN KEY ([Id_Nivel_Riesgo])
    REFERENCES [dbo].[Nivel_RiesgoSet]
        ([Id_nivel_Riesgo])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Nivel_RiesgoPuesto'
CREATE INDEX [IX_FK_Nivel_RiesgoPuesto]
ON [dbo].[PuestoSet]
    ([Id_Nivel_Riesgo]);
GO

-- Creating foreign key on [Id_Puesto] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [FK_PuestoEmpleado]
    FOREIGN KEY ([Id_Puesto])
    REFERENCES [dbo].[PuestoSet]
        ([Id_Puesto])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PuestoEmpleado'
CREATE INDEX [IX_FK_PuestoEmpleado]
ON [dbo].[EmpleadoSet]
    ([Id_Puesto]);
GO

-- Creating foreign key on [Id_Empleado] in table 'Registro_transaccion_deduccionSet'
ALTER TABLE [dbo].[Registro_transaccion_deduccionSet]
ADD CONSTRAINT [FK_EmpleadoRegistro_transaccion_deduccion]
    FOREIGN KEY ([Id_Empleado])
    REFERENCES [dbo].[EmpleadoSet]
        ([Id_Empleado])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoRegistro_transaccion_deduccion'
CREATE INDEX [IX_FK_EmpleadoRegistro_transaccion_deduccion]
ON [dbo].[Registro_transaccion_deduccionSet]
    ([Id_Empleado]);
GO

-- Creating foreign key on [Id_Tipo_Deducc] in table 'Registro_transaccion_deduccionSet'
ALTER TABLE [dbo].[Registro_transaccion_deduccionSet]
ADD CONSTRAINT [FK_Tipo_de_DeduccionRegistro_transaccion_deduccion]
    FOREIGN KEY ([Id_Tipo_Deducc])
    REFERENCES [dbo].[Tipo_de_DeduccionSet]
        ([Id_Tipo_Deduccion])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_de_DeduccionRegistro_transaccion_deduccion'
CREATE INDEX [IX_FK_Tipo_de_DeduccionRegistro_transaccion_deduccion]
ON [dbo].[Registro_transaccion_deduccionSet]
    ([Id_Tipo_Deducc]);
GO

-- Creating foreign key on [Id_Departamento] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [FK_DepartamentoEmpleado]
    FOREIGN KEY ([Id_Departamento])
    REFERENCES [dbo].[DepartamentoSet]
        ([Id_Departamento])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoEmpleado'
CREATE INDEX [IX_FK_DepartamentoEmpleado]
ON [dbo].[EmpleadoSet]
    ([Id_Departamento]);
GO

-- Creating foreign key on [Id_Empleado] in table 'Registro_TransaccionSet'
ALTER TABLE [dbo].[Registro_TransaccionSet]
ADD CONSTRAINT [FK_EmpleadoRegistro_Transaccion]
    FOREIGN KEY ([Id_Empleado])
    REFERENCES [dbo].[EmpleadoSet]
        ([Id_Empleado])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoRegistro_Transaccion'
CREATE INDEX [IX_FK_EmpleadoRegistro_Transaccion]
ON [dbo].[Registro_TransaccionSet]
    ([Id_Empleado]);
GO

-- Creating foreign key on [Id_Tipo_Ingreso] in table 'Registro_TransaccionSet'
ALTER TABLE [dbo].[Registro_TransaccionSet]
ADD CONSTRAINT [FK_Tipo_de_IngresoRegistro_Transaccion]
    FOREIGN KEY ([Id_Tipo_Ingreso])
    REFERENCES [dbo].[Tipo_de_IngresoSet]
        ([Id_Tipo_Ingreso])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_de_IngresoRegistro_Transaccion'
CREATE INDEX [IX_FK_Tipo_de_IngresoRegistro_Transaccion]
ON [dbo].[Registro_TransaccionSet]
    ([Id_Tipo_Ingreso]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------