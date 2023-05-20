public interface IVocabsRepository
{
    public Task<GetMemberVocablistsResultDto> GetMemberVocablists(GetMemberVocablistsQueryDto dto);
    public Task<GetVocablistResultDto> GetVocablist(GetVocablistQueryDto dto);
    public Task<GetVocabResultDto> GetVocab(GetVocabQueryDto dto);
    public Task UpdateVocablist(UpdateVocablistDto dto);
    public Task InsertVocablist(InsertVocablistDto dto);
    public Task DeleteVocablist(DeleteVocablistDto dto);
}