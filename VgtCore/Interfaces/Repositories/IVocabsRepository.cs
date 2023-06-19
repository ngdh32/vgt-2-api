public interface IVocabsRepository
{
    public Task<List<VocablistEntity>> GetMemberVocablists(string memberId);
    public Task<VocablistEntity> GetVocablist(string vocablistId);
    public Task<VocabEntity> GetVocab(string vocabId);
    public Task UpdateVocablist(VocablistEntity vocablist);
    public Task InsertVocablist(VocabEntity vocab);
    public Task DeleteVocablist(string vocablistId);
}