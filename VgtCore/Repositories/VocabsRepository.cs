public class VocabsRepository : IVocabsRepository
{
    public Task DeleteVocablist(string vocablistId)
    {
        throw new NotImplementedException();
    }

    public Task<List<VocablistEntity>> GetMemberVocablists(string memberId)
    {
        throw new NotImplementedException();
    }

    public Task<VocabEntity> GetVocab(string vocabId)
    {
        throw new NotImplementedException();
    }

    public Task<VocablistEntity> GetVocablist(string vocablistId)
    {
        throw new NotImplementedException();
    }

    public Task InsertVocablist(VocabEntity vocab)
    {
        throw new NotImplementedException();
    }

    public Task UpdateVocablist(VocablistEntity vocablist)
    {
        throw new NotImplementedException();
    }
}