CREATE TABLE [dbo].[Cursos]
(
	[Id]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL, 
    [Nombre] VARCHAR(50) NULL, 
    [Descripcion] VARCHAR(MAX) NULL, 
    CONSTRAINT [PK_Cursos] PRIMARY KEY ([Id])
)
