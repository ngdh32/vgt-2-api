public class EFVocabRepository : IVocabRepository
{
    private readonly VgtDbContext _vgtContext;

    public EFVocabRepository(VgtDbContext vgtContext){
        _vgtContext = vgtContext;
    }

    public void Add(VocabEntity entity)
    {
        var newEntity = new EFVocabEntity(){
            Word = entity.Word,
            Definition = entity.Definition,
            VocablistId = entity.VocablistId
        };

        _vgtContext.Vocabs.Add(newEntity);
    }

    public void Delete(string id)
    {
        var toDelete = _vgtContext.Vocabs.FirstOrDefault(x => x.Id == id);
        if (toDelete is not null){
            _vgtContext.Vocabs.Remove(toDelete);
        }
    }

    public VocabEntity Get(string id)
    {
        var efEntity = _vgtContext.Vocabs.FirstOrDefault(x => x.Id == id);
        if (efEntity is null){
            return (VocabEntity)null;
        }
        
        var entity = new VocabEntity(){
            Id = efEntity.Id,
            Word = efEntity.Word,
            Definition = efEntity.Definition,
            VocablistId = efEntity.VocablistId
        };
        return entity;
    }

    public List<VocabEntity> GetAll()
    {
        var result = new List<VocabEntity>();
        foreach(var entity in _vgtContext.Vocabs.ToList()){
            var item = new VocabEntity(){
                Id = entity.Id,
                Word = entity.Word,
                Definition = entity.Definition,
                VocablistId = entity.VocablistId
            };

            result.Add(item);
        }

        return result;
    }

    public void Update(VocabEntity entity)
    {
        var efEntity = _vgtContext.Vocabs.First(x => x.Id == entity.Id);
        efEntity.Word = entity.Word;
        efEntity.Definition = entity.Definition;
        efEntity.VocablistId = entity.VocablistId;
    }
}