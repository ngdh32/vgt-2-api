using AutoMapper;

public static class VocabsQueryServiceDtoMappers
{
    public static void SetMapperConfiguration(IMapperConfigurationExpression cfg)
    {
        cfg.CreateMap<VocabEntity, VocabViewDto>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Word, act => act.MapFrom(src => src.Word))
            .ForMember(dest => dest.Definition, act => act.MapFrom(src => src.Definition))
            .ForMember(dest => dest.Examples, act => act.MapFrom(src => src.Examples));

        cfg.CreateMap<ExampleEntity, ExampleViewDto>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Sentence, act => act.MapFrom(src => src.Sentence));

        cfg.CreateMap<VocablistEntity, VocablistViewDto>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.Language , act => act.MapFrom(src => src.Language))
            .ForMember(dest => dest.Vocabs, act => act.MapFrom(src => src.Vocabs));

        cfg.CreateMap<VocablistEntity, VocablistBaseDto>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.Language , act => act.MapFrom(src => src.Language));
    }
}