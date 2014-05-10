
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/10/2014 08:41:55
-- Generated from EDMX file: C:\Users\Matthew\Github\WebServices\Project2\WebServices\StoryModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CS491];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryStory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stories] DROP CONSTRAINT [FK_CategoryStory];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Stories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stories];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Stories'
CREATE TABLE [dbo].[Stories] (
    [Id] uniqueidentifier  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Subtitle] nvarchar(max)  NOT NULL,
    [Body] nvarchar(max)  NOT NULL,
    [DatePublished] datetime  NOT NULL,
    [Lat] float  NULL,
    [Lng] float  NULL,
    [authorId] uniqueidentifier  NOT NULL,
    [CategoryId] uniqueidentifier  NOT NULL,
    [DateUpdated] datetime  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Stories'
ALTER TABLE [dbo].[Stories]
ADD CONSTRAINT [PK_Stories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoryId] in table 'Stories'
ALTER TABLE [dbo].[Stories]
ADD CONSTRAINT [FK_CategoryStory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryStory'
CREATE INDEX [IX_FK_CategoryStory]
ON [dbo].[Stories]
    ([CategoryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------