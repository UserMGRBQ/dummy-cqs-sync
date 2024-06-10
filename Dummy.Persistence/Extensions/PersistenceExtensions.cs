using Microsoft.Extensions.DependencyInjection;

namespace Dummy.Persistence.Extensions;

public static class PersistenceExtensions
{
    public static IServiceCollection AddDummyPersistence(this IServiceCollection services)
    {
        services.AddDbContext<DummyCommandContext>((context, options) =>
            options.UseSqlServer(context.GetRequiredService<IConfiguration>().GetConnectionString("DummyCommandConnection")));

        services.AddDbContext<DummyQueryContext>((context, options) =>
            options.UseSqlServer(context.GetRequiredService<IConfiguration>().GetConnectionString("DummyQueryConnection")));

        services.AddScoped<ICommandUserRepository, CommandUserRepository>();
        services.AddScoped<IQueryUserRepository, QueryUserRepository>();

        return services;
    }
}