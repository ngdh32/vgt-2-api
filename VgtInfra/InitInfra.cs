using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class InitInfra{
    public static void InitService(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = Environment.GetEnvironmentVariable("MYSQLCONNECTIONSTRING");
        Console.WriteLine(connectionString);
        services.AddDbContext<VgtDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), mySqlOptions => {
            mySqlOptions.MigrationsAssembly("VgtApi");
        }));

        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedEmail = false)
            .AddEntityFrameworkStores<VgtDbContext>();


        services.AddTransient<IUnitOfWork, EFUnitOfWork>();
    }
}