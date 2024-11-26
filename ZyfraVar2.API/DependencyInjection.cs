using ZyfraVar2.Repository;
using ZyfraVar2.Repository.Interfaces;
using ZyfraVar2.Services;
using ZyfraVar2.Services.Interfaces;
namespace ZyfraVar2.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection CreateDependencies(this IServiceCollection services,  string userDatafilePath)
        {
            
            services
                .AddSingleton<IUserRepository>(new UserRepository(userDatafilePath))
                .AddSingleton<ISessionRepository>(new SessionRepository())
                .AddSingleton<ISessionService, SessionService>()
                .AddSingleton<IAuthService, AuthService>();

            return services;
        }
    }
}
