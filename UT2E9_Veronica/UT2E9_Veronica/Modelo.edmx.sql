
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2023 17:34:54
-- Generated from EDMX file: C:\codigo\UT2E9_Veronica\UT2E9_Veronica\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Biblioteca];
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

-- Creating table 'Peliculas'
CREATE TABLE [dbo].[Peliculas] (
    [PeliculaId] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Anno] int  NOT NULL,
    [Genero] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Libros'
CREATE TABLE [dbo].[Libros] (
    [LibroId] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Anno] int  NOT NULL,
    [Autor] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PeliculaId] in table 'Peliculas'
ALTER TABLE [dbo].[Peliculas]
ADD CONSTRAINT [PK_Peliculas]
    PRIMARY KEY CLUSTERED ([PeliculaId] ASC);
GO

-- Creating primary key on [LibroId] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [PK_Libros]
    PRIMARY KEY CLUSTERED ([LibroId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------