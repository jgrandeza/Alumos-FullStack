using jeancarlos.grandezaguilar.alumnos.services.Domain.Escuela.Entidades;
using Microsoft.EntityFrameworkCore;

namespace jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Persistence.Contexts
{
    public partial class EscuelaContext: DbContext
    {

        public void EnsureSeedDataForContext()
        {
            List<Alumno> alumnos = new List<Alumno>()
            {

                new Alumno()
                {
                    Id= new Guid(""),
                    ApePaterno="Grandez",
                    ApeMaterno="Aguilar",
                    Nombre="Jean Carlos",
                    FechaNac= new DateTime(1993,6,21),
                    Tdocumento=1,
                    Ndocumento="72196262"
                },
                new Alumno()
                {
                    Id= new Guid(""),
                    ApePaterno="Grandez",
                    ApeMaterno="Aguilar",
                    Nombre="Jose",
                    FechaNac= new DateTime(2000,1,23),
                    Tdocumento=1,
                    Ndocumento="72196266"
                },
                new Alumno()
                {
                    Id= new Guid(""),
                    ApePaterno="Paredes",
                    ApeMaterno="Sarrome",
                    Nombre="Natalie",
                    FechaNac= new DateTime(1991,12,26),
                    Tdocumento=1,
                    Ndocumento="72488582"
                }
            };

            Alumnos.AddRange(alumnos);
            SaveChanges();
        }

    }
}
