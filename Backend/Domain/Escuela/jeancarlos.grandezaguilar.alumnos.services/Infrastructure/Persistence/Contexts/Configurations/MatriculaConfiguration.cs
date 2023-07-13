﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using jeancarlos.grandezaguilar.alumnos.services.Domain.Escuela.Entidades;
using jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Persistence.Contexts.Configurations
{
    public partial class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> entity)
        {
            entity.ToTable("Matricula");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Matriculas)
            .HasForeignKey(d => d.IdAlumno)
            .HasConstraintName("FK_Matricula_Alumno");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Matriculas)
            .HasForeignKey(d => d.IdCurso)
            .HasConstraintName("FK_Matricula_Curso");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Matricula> entity);
    }
}
