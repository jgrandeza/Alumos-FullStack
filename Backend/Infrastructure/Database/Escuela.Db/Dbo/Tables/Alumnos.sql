CREATE TABLE [dbo].[Alumnos]
(
	[Id]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Ape_Paterno] VARCHAR(50) NULL, 
    [Ape_Materno] VARCHAR(50) NULL, 
    [Nombre] VARCHAR(50) NULL, 
    [FechaNac] DATE NULL, 
    [TDocumento] INT NULL, 
    [NDocumento] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Alumnos] PRIMARY KEY ([Id])

)
