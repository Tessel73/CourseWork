
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/01/2014 00:25:54
-- Generated from EDMX file: C:\Users\User\Documents\Visual Studio 2013\Projects\OOP_Course_Work\OOP_Course_Work\CWModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OOP_CourseWork_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ContractClient_Contract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractClient] DROP CONSTRAINT [FK_ContractClient_Contract];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractClient_Client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractClient] DROP CONSTRAINT [FK_ContractClient_Client];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractTur_Contract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractTur] DROP CONSTRAINT [FK_ContractTur_Contract];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractTur_Tur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractTur] DROP CONSTRAINT [FK_ContractTur_Tur];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractHotel_Contract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractHotel] DROP CONSTRAINT [FK_ContractHotel_Contract];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractHotel_Hotel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractHotel] DROP CONSTRAINT [FK_ContractHotel_Hotel];
GO
IF OBJECT_ID(N'[dbo].[FK_ExcursionTur_Excursion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExcursionTur] DROP CONSTRAINT [FK_ExcursionTur_Excursion];
GO
IF OBJECT_ID(N'[dbo].[FK_ExcursionTur_Tur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExcursionTur] DROP CONSTRAINT [FK_ExcursionTur_Tur];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO
IF OBJECT_ID(N'[dbo].[Contract]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contract];
GO
IF OBJECT_ID(N'[dbo].[Hotel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hotel];
GO
IF OBJECT_ID(N'[dbo].[Tur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tur];
GO
IF OBJECT_ID(N'[dbo].[Excursion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Excursion];
GO
IF OBJECT_ID(N'[dbo].[ContractClient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractClient];
GO
IF OBJECT_ID(N'[dbo].[ContractTur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractTur];
GO
IF OBJECT_ID(N'[dbo].[ContractHotel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractHotel];
GO
IF OBJECT_ID(N'[dbo].[ExcursionTur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExcursionTur];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Client'
CREATE TABLE [dbo].[Client] (
    [ClientID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Passport] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Contract'
CREATE TABLE [dbo].[Contract] (
    [ContractID] int IDENTITY(1,1) NOT NULL,
    [ClientID] nvarchar(max)  NOT NULL,
    [TurID] nvarchar(max)  NOT NULL,
    [HotelID] nvarchar(max)  NOT NULL,
    [Number] int  NOT NULL,
    [Cost] float  NOT NULL,
    [TotalCost] float  NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Hotel'
CREATE TABLE [dbo].[Hotel] (
    [HotelID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Rating] int  NULL,
    [Cost] float  NOT NULL,
    [Food] nvarchar(max)  NULL
);
GO

-- Creating table 'Tur'
CREATE TABLE [dbo].[Tur] (
    [TurID] int IDENTITY(1,1) NOT NULL,
    [Country] nvarchar(max)  NULL,
    [DateO] datetime  NOT NULL,
    [DateI] datetime  NOT NULL,
    [Day_Night] nvarchar(max)  NOT NULL,
    [Cost] float  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL
);
GO

-- Creating table 'Excursion'
CREATE TABLE [dbo].[Excursion] (
    [ExcursionID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Rating] int  NULL,
    [Length] nvarchar(max)  NULL,
    [Time] nvarchar(max)  NULL,
    [Cost] float  NOT NULL,
    [Note] nvarchar(max)  NULL
);
GO

-- Creating table 'ContractClient'
CREATE TABLE [dbo].[ContractClient] (
    [ContractClient_Client_ContractID] int  NOT NULL,
    [Client_ClientID] int  NOT NULL
);
GO

-- Creating table 'ContractTur'
CREATE TABLE [dbo].[ContractTur] (
    [ContractTur_Tur_ContractID] int  NOT NULL,
    [Tur_TurID] int  NOT NULL
);
GO

-- Creating table 'ContractHotel'
CREATE TABLE [dbo].[ContractHotel] (
    [ContractHotel_Hotel_ContractID] int  NOT NULL,
    [Hotel_HotelID] int  NOT NULL
);
GO

-- Creating table 'ExcursionTur'
CREATE TABLE [dbo].[ExcursionTur] (
    [Excursion_ExcursionID] int  NOT NULL,
    [Tur_TurID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClientID] in table 'Client'
ALTER TABLE [dbo].[Client]
ADD CONSTRAINT [PK_Client]
    PRIMARY KEY CLUSTERED ([ClientID] ASC);
GO

-- Creating primary key on [ContractID] in table 'Contract'
ALTER TABLE [dbo].[Contract]
ADD CONSTRAINT [PK_Contract]
    PRIMARY KEY CLUSTERED ([ContractID] ASC);
GO

-- Creating primary key on [HotelID] in table 'Hotel'
ALTER TABLE [dbo].[Hotel]
ADD CONSTRAINT [PK_Hotel]
    PRIMARY KEY CLUSTERED ([HotelID] ASC);
GO

-- Creating primary key on [TurID] in table 'Tur'
ALTER TABLE [dbo].[Tur]
ADD CONSTRAINT [PK_Tur]
    PRIMARY KEY CLUSTERED ([TurID] ASC);
GO

-- Creating primary key on [ExcursionID] in table 'Excursion'
ALTER TABLE [dbo].[Excursion]
ADD CONSTRAINT [PK_Excursion]
    PRIMARY KEY CLUSTERED ([ExcursionID] ASC);
GO

-- Creating primary key on [ContractClient_Client_ContractID], [Client_ClientID] in table 'ContractClient'
ALTER TABLE [dbo].[ContractClient]
ADD CONSTRAINT [PK_ContractClient]
    PRIMARY KEY CLUSTERED ([ContractClient_Client_ContractID], [Client_ClientID] ASC);
GO

-- Creating primary key on [ContractTur_Tur_ContractID], [Tur_TurID] in table 'ContractTur'
ALTER TABLE [dbo].[ContractTur]
ADD CONSTRAINT [PK_ContractTur]
    PRIMARY KEY CLUSTERED ([ContractTur_Tur_ContractID], [Tur_TurID] ASC);
GO

-- Creating primary key on [ContractHotel_Hotel_ContractID], [Hotel_HotelID] in table 'ContractHotel'
ALTER TABLE [dbo].[ContractHotel]
ADD CONSTRAINT [PK_ContractHotel]
    PRIMARY KEY CLUSTERED ([ContractHotel_Hotel_ContractID], [Hotel_HotelID] ASC);
GO

-- Creating primary key on [Excursion_ExcursionID], [Tur_TurID] in table 'ExcursionTur'
ALTER TABLE [dbo].[ExcursionTur]
ADD CONSTRAINT [PK_ExcursionTur]
    PRIMARY KEY CLUSTERED ([Excursion_ExcursionID], [Tur_TurID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ContractClient_Client_ContractID] in table 'ContractClient'
ALTER TABLE [dbo].[ContractClient]
ADD CONSTRAINT [FK_ContractClient_Contract]
    FOREIGN KEY ([ContractClient_Client_ContractID])
    REFERENCES [dbo].[Contract]
        ([ContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Client_ClientID] in table 'ContractClient'
ALTER TABLE [dbo].[ContractClient]
ADD CONSTRAINT [FK_ContractClient_Client]
    FOREIGN KEY ([Client_ClientID])
    REFERENCES [dbo].[Client]
        ([ClientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractClient_Client'
CREATE INDEX [IX_FK_ContractClient_Client]
ON [dbo].[ContractClient]
    ([Client_ClientID]);
GO

-- Creating foreign key on [ContractTur_Tur_ContractID] in table 'ContractTur'
ALTER TABLE [dbo].[ContractTur]
ADD CONSTRAINT [FK_ContractTur_Contract]
    FOREIGN KEY ([ContractTur_Tur_ContractID])
    REFERENCES [dbo].[Contract]
        ([ContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tur_TurID] in table 'ContractTur'
ALTER TABLE [dbo].[ContractTur]
ADD CONSTRAINT [FK_ContractTur_Tur]
    FOREIGN KEY ([Tur_TurID])
    REFERENCES [dbo].[Tur]
        ([TurID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractTur_Tur'
CREATE INDEX [IX_FK_ContractTur_Tur]
ON [dbo].[ContractTur]
    ([Tur_TurID]);
GO

-- Creating foreign key on [ContractHotel_Hotel_ContractID] in table 'ContractHotel'
ALTER TABLE [dbo].[ContractHotel]
ADD CONSTRAINT [FK_ContractHotel_Contract]
    FOREIGN KEY ([ContractHotel_Hotel_ContractID])
    REFERENCES [dbo].[Contract]
        ([ContractID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Hotel_HotelID] in table 'ContractHotel'
ALTER TABLE [dbo].[ContractHotel]
ADD CONSTRAINT [FK_ContractHotel_Hotel]
    FOREIGN KEY ([Hotel_HotelID])
    REFERENCES [dbo].[Hotel]
        ([HotelID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractHotel_Hotel'
CREATE INDEX [IX_FK_ContractHotel_Hotel]
ON [dbo].[ContractHotel]
    ([Hotel_HotelID]);
GO

-- Creating foreign key on [Excursion_ExcursionID] in table 'ExcursionTur'
ALTER TABLE [dbo].[ExcursionTur]
ADD CONSTRAINT [FK_ExcursionTur_Excursion]
    FOREIGN KEY ([Excursion_ExcursionID])
    REFERENCES [dbo].[Excursion]
        ([ExcursionID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tur_TurID] in table 'ExcursionTur'
ALTER TABLE [dbo].[ExcursionTur]
ADD CONSTRAINT [FK_ExcursionTur_Tur]
    FOREIGN KEY ([Tur_TurID])
    REFERENCES [dbo].[Tur]
        ([TurID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExcursionTur_Tur'
CREATE INDEX [IX_FK_ExcursionTur_Tur]
ON [dbo].[ExcursionTur]
    ([Tur_TurID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------