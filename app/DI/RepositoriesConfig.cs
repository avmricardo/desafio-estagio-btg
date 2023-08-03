using repository;
using repository.Interfaces;

namespace app.DI
{
    public static class RepositoriesConfig
    {
        public static void AddConfigRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
        }
    }
}
