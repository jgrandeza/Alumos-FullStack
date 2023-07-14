using jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Persistence.Extensions
{
    public class PersistenceOptions
    {
        public string ConnectionString { get; set; }
    }
    public static class PersistenceExtension
    {

        public static void AddPersistence(this IServiceCollection services, Action<PersistenceOptions> configure)
        {
            var options = new PersistenceOptions();
            configure(options);

            services.AddDbContext<EscuelaContext>(o => o.UseSqlServer(options.ConnectionString));
        }
    }
}
