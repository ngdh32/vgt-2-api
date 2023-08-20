using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

public static class InitCor{
    public static void InitCoreService(IServiceCollection services)
    {
        services.AddAutoMapper(cfg => {
            VocabsQueryServiceDtoMappers.SetMapperConfiguration(cfg);
        });
    }
}