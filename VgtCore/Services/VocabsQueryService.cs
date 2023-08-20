using AutoMapper;

public class VocabsQueryService : IVocabsQueryService
{
    private readonly IVocablistRepository _vocablistRepo;
    private readonly IVocabRepository _vocabRepo;
    private readonly IExampleRepository _exampleRepo;
    private readonly IMapper _mapper;

    public VocabsQueryService(IVocablistRepository vocablistRepo
        , IVocabRepository vocabRepo
        , IExampleRepository exampleRepo
        , IMapper mapper)
    {
        _vocablistRepo = vocablistRepo;
        _vocabRepo = vocabRepo;
        _exampleRepo = exampleRepo;
        _mapper = mapper;
    }

    public async Task<GetMemberVocablistsResponseDto> GetMemberVocablists(GetMemberVocablistsRequestDto dto)
    {
        // var list = await _repo.GetMemberVocablists(dto.MemberId);
        // var result = _mapper.Map<List<VocablistBaseDto>>(list);
        // return new GetMemberVocablistsResponseDto(result);
        throw new NotImplementedException();

    }

    public async Task<GetVocablistResponseDto> GetVocablist(GetVocablistRequestDto dto)
    {
        // var list = await _repo.GetVocablist(dto.VocablistId);
        // var result = _mapper.Map<VocablistViewDto>(list);
        // return new GetVocablistResponseDto(result);
        throw new NotImplementedException();
    }
}