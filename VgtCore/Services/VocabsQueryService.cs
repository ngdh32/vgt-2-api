using AutoMapper;

public class VocabsQueryService : IVocabsQueryService
{
    private readonly IVocabsRepository _repo;
    private readonly IMapper _mapper;

    public VocabsQueryService(IVocabsRepository repo, IMapper mapper)
    {
        _repo = repo;
    }

    public async Task<GetMemberVocablistsResponseDto> GetMemberVocablists(GetMemberVocablistsRequestDto dto)
    {
        var list = await _repo.GetMemberVocablists(dto.MemberId);
        var result = _mapper.Map<List<VocablistBaseDto>>(list);
        return new GetMemberVocablistsResponseDto(result);
    }

    public async Task<GetVocablistResponseDto> GetVocablist(GetVocablistRequestDto dto)
    {
        var list = await _repo.GetVocablist(dto.VocablistId);
        var result = _mapper.Map<VocablistViewDto>(list);
        return new GetVocablistResponseDto(result);
    }
}