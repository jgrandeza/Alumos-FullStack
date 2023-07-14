using jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace jeancarlos.grandezaguilar.alumnos.services.Infrastructure.Extensions
{
    public class InfrastructureOptions
    {
        public string ConnectionString { get; set; }
    }
    public static class InfrastructureExtension
    {

        public static void AddInfrastructure(this IServiceCollection services, Action<InfrastructureOptions> configure)
        {
            var options = new InfrastructureOptions();
            configure(options);

            services.AddPersistence(opt => opt.ConnectionString = options.ConnectionString);
        }
    }
}
