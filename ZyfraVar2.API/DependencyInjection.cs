using Microsoft.EntityFrameworkCore;
using ZyfraVar2.Repository;
using ZyfraVar2.Repository.Interfaces;
using ZyfraVar2.Services;
using ZyfraVar2.Services.Interfaces;
namespace ZyfraVar2.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection CreateDependencies(this IServiceCollection services,  string connectionString)
        {
            services.AddDbContext<SessionsContext>(options =>
        options.UseNpgsql(connectionString));

            services
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<ISessionRepository, SessionRepository>()
                .AddScoped<ISessionService, SessionService>()
                .AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
