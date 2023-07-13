CREATE TABLE [dbo].[Matricula]
(
	[Id] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [IdAlumno] UNIQUEIDENTIFIER NOT NULL,
    [IdCurso] UNIQUEIDENTIFIER NOT NULL, 
    [FechaRegistro] DATETIME NULL,
    CONSTRAINT [FK_Matricula_Alumno] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumnos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Matricula_Curso] FOREIGN KEY ([IdCurso]) REFERENCES [dbo].[Cursos] ([Id]) ON DELETE CASCADE, 
    CONSTRAINT [PK_Matricula] PRIMARY KEY ([Id])
)
