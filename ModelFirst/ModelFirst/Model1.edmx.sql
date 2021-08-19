
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/19/2021 20:28:20
-- Generated from EDMX file: C:\Users\AsataTarde\Desktop\CURSONET\alei87\CURSO_NET\ModelFirst\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [modelFirst];
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

-- Creating table 'EditorialSet'
CREATE TABLE [dbo].[EditorialSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LibroSet'
CREATE TABLE [dbo].[LibroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NOT NULL,
    [Id_Editoral] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EditorialSet'
ALTER TABLE [dbo].[EditorialSet]
ADD CONSTRAINT [PK_EditorialSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [PK_LibroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_Editoral] in table 'LibroSet'
ALTER TABLE [dbo].[LibroSet]
ADD CONSTRAINT [FK_EditorialLibro]
    FOREIGN KEY ([Id_Editoral])
    REFERENCES [dbo].[EditorialSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EditorialLibro'
CREATE INDEX [IX_FK_EditorialLibro]
ON [dbo].[LibroSet]
    ([Id_Editoral]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------