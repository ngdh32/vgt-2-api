public class EFVocabRepository : IVocabRepository
{
    void IBaseRepository<VocabEntity>.Add(VocabEntity entity)
    {
        throw new NotImplementedException();
    }

    void IBaseRepository<VocabEntity>.Delete(string id)
    {
        throw new NotImplementedException();
    }

    VocabEntity IBaseRepository<VocabEntity>.Get(string id)
    {
        throw new NotImplementedException();
    }

    List<VocabEntity> IBaseRepository<VocabEntity>.GetAll()
    {
        throw new NotImplementedException();
    }

    void IBaseRepository<VocabEntity>.Update(VocabEntity entity)
    {
        throw new NotImplementedException();
    }
}