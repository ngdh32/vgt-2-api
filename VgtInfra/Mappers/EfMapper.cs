using AutoMapper;

public static class EfEntityMapper
{
    public static void SetMapperConfiguration(IMapperConfigurationExpression cfg)
    {
        cfg.CreateMap<VocablistEntity, EfVocablistEntity>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Language, act => act.MapFrom(src => src.Language))
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name));

        cfg.CreateMap<ExampleEntity, EfExampleEntity>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Sentence, act => act.MapFrom(src => src.Sentence));

        cfg.CreateMap<VocabEntity, EfVocabEntity>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
            .ForMember(dest => dest.Word, act => act.MapFrom(src => src.Word))
            .ForMember(dest => dest.Definition, act => act.MapFrom(src => src.Definition));
    }
}