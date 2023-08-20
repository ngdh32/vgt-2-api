using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class InitInfra{
    public static void InitService(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["ConnectionString"];
        services.AddDbContext<VgtDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), mySqlOptions => {
            mySqlOptions.MigrationsAssembly("VgtApi");
        }));

        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedEmail = false)
            .AddEntityFrameworkStores<VgtDbContext>();


        services.AddTransient<IVocabRepository, EFVocabRepository>();
        services.AddTransient<IVocablistRepository, EFVocablistRepository>();
        services.AddTransient<IExampleRepository, EFExampleRepository>();
    }
}