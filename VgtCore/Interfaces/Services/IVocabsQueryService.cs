public interface IVocabsQueryService
{
    public Task<GetMemberVocablistsResponseDto> GetMemberVocablists(GetMemberVocablistsRequestDto dto);
    public Task<GetVocablistResponseDto> GetVocablist(GetVocablistRequestDto dto);
}