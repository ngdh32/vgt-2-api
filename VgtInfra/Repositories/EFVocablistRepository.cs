public class EFVocablistRepository : IVocablistRepository
{
    private readonly VgtDbContext _vgtContext;

    public EFVocablistRepository(VgtDbContext vgtContext){
        _vgtContext = vgtContext;
    }

    public void Add(VocablistEntity entity)
    {
        var newEntity = new EFVocablistEntity(){
            Name = entity.Name,
            Language = (int)entity.Language
        };

        _vgtContext.Vocablists.Add(newEntity);
    }

    public void Delete(string id)
    {
        var toDelete = _vgtContext.Vocablists.FirstOrDefault(x => x.Id == id);
        if (toDelete is not null){
            _vgtContext.Vocablists.Remove(toDelete);
        }
    }

    public VocablistEntity Get(string id)
    {
        var efEntity = _vgtContext.Vocablists.FirstOrDefault(x => x.Id == id);
        if (efEntity is null){
            return (VocablistEntity)null;
        }
        
        var entity = new VocablistEntity(){
            Id = efEntity.Id,
            Name = efEntity.Name,
            Language = (LanguageType)efEntity.Language
        };
        return entity;
    }

    public List<VocablistEntity> GetAll()
    {
        var result = new List<VocablistEntity>();
        foreach(var entity in _vgtContext.Vocablists.ToList()){
            var item = new VocablistEntity(){
                Id = entity.Id,
                Name = entity.Name,
                Language = (LanguageType)entity.Language
            };

            result.Add(item);
        }

        return result;
    }

    public void Update(VocablistEntity entity)
    {
        var efEntity = _vgtContext.Vocablists.First(x => x.Id == entity.Id);
        efEntity.Name = entity.Name;
        efEntity.Language = (int)entity.Language;
    }
}