CREATE TABLE [dbo].[Employes]
(
	[Id]       INT          NOT NULL IDENTITY, 
    [FullName] VARCHAR(50) NOT NULL, 
    [Sex] INT NOT NULL, 
    [Birthday] DATE NOT NULL
	CONSTRAINT CheckAge CHECK ([Birthday] BETWEEN Dateadd(year, -100,GetDate()) and  Dateadd(year, -18,GetDate()))
)

GO

CREATE UNIQUE INDEX [IX_Table_Column] ON [dbo].[Employes] ([FullName], [Birthday])

GO

CREATE TABLE [dbo].[TypeDocDef]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TypeDoc] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)

GO

CREATE TABLE [dbo].[Documents]
(
	[Id] INT NOT NULL, 
    [SelialNumber] NCHAR(20) NOT NULL, 
    [TypeDoc] INT NOT NULL,
	[DateIssue] DATE NOT NULL, 
    [AutorIssue] VARCHAR(50) NOT NULL, 
    CONSTRAINT FK_DocType_Documents FOREIGN KEY (TypeDoc) REFERENCES [dbo].[TypeDocDef] (ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_Employe_Documents FOREIGN KEY (ID) REFERENCES [dbo].[Employes] (ID) ON DELETE CASCADE ON UPDATE CASCADE
)

GO

CREATE UNIQUE INDEX [IX_Unique_Serial_Type] ON [dbo].[Documents] ([SelialNumber], [TypeDoc])

GO

CREATE TABLE [dbo].[TypePhoneDef]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TypePhone] VARCHAR(50) NULL
)

GO

CREATE TABLE [dbo].[Phone]
(
	[Id] INT NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [TypePhone] INT NOT NULL,
	CONSTRAINT FK_Employe_Phone FOREIGN KEY (ID) REFERENCES [dbo].[Employes] (ID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_TypePhone_Phone FOREIGN KEY (TypePhone) REFERENCES [dbo].[TypePhoneDef] (ID) ON DELETE CASCADE ON UPDATE CASCADE
)

GO

CREATE UNIQUE INDEX [IX_Unique_Number_Type] ON [dbo].[Phone] ([PhoneNumber], [TypePhone])