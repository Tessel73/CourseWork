
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/26/2014 05:14:26
-- Generated from EDMX file: C:\Users\User\Documents\Visual Studio 2013\BackUp\Ласт\OOP_Course_Work\OOP_Course_Work\CWModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_ContractClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contract] DROP CONSTRAINT [FK_ContractClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractTur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contract] DROP CONSTRAINT [FK_ContractTur];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractHotel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contract] DROP CONSTRAINT [FK_ContractHotel];
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
    [Client_ClientID] int  NOT NULL,
    [Tur_TurID] int  NOT NULL,
    [Hotel_HotelID] int  NOT NULL
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

-- Creating primary key on [Excursion_ExcursionID], [Tur_TurID] in table 'ExcursionTur'
ALTER TABLE [dbo].[ExcursionTur]
ADD CONSTRAINT [PK_ExcursionTur]
    PRIMARY KEY CLUSTERED ([Excursion_ExcursionID], [Tur_TurID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_ClientID] in table 'Contract'
ALTER TABLE [dbo].[Contract]
ADD CONSTRAINT [FK_ContractClient]
    FOREIGN KEY ([Client_ClientID])
    REFERENCES [dbo].[Client]
        ([ClientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractClient'
CREATE INDEX [IX_FK_ContractClient]
ON [dbo].[Contract]
    ([Client_ClientID]);
GO

-- Creating foreign key on [Tur_TurID] in table 'Contract'
ALTER TABLE [dbo].[Contract]
ADD CONSTRAINT [FK_ContractTur]
    FOREIGN KEY ([Tur_TurID])
    REFERENCES [dbo].[Tur]
        ([TurID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractTur'
CREATE INDEX [IX_FK_ContractTur]
ON [dbo].[Contract]
    ([Tur_TurID]);
GO

-- Creating foreign key on [Hotel_HotelID] in table 'Contract'
ALTER TABLE [dbo].[Contract]
ADD CONSTRAINT [FK_ContractHotel]
    FOREIGN KEY ([Hotel_HotelID])
    REFERENCES [dbo].[Hotel]
        ([HotelID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractHotel'
CREATE INDEX [IX_FK_ContractHotel]
ON [dbo].[Contract]
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