public class EFExampleRepository : IExampleRepository
{
    private readonly VgtDbContext _vgtContext;

    public EFExampleRepository(VgtDbContext vgtContext){
        _vgtContext = vgtContext;
    }

    public void Add(ExampleEntity entity)
    {
        var newEntity = new EFExampleEntity(){
            Sentence = entity.Sentence,
            VocabId = entity.VocabId
        };

        _vgtContext.Examples.Add(newEntity);
    }

    public void Delete(string id)
    {
        var toDelete = _vgtContext.Examples.FirstOrDefault(x => x.Id == id);
        if (toDelete is not null){
            _vgtContext.Examples.Remove(toDelete);
        }
    }

    public ExampleEntity Get(string id)
    {
        var efEntity = _vgtContext.Examples.FirstOrDefault(x => x.Id == id);
        if (efEntity is null){
            return (ExampleEntity)null;
        }
        
        var entity = new ExampleEntity(){
            Sentence = efEntity.Sentence,
            Id = efEntity.Id,
            VocabId = efEntity.VocabId
        };
        return entity;
    }

    public List<ExampleEntity> GetAll()
    {
        var result = new List<ExampleEntity>();
        foreach(var entity in _vgtContext.Examples.ToList()){
            var item = new ExampleEntity(){
                Sentence = entity.Sentence,
                Id = entity.Id,
                VocabId = entity.VocabId
            };

            result.Add(item);
        }

        return result;
    }

    public void Update(ExampleEntity entity)
    {
        var efEntity = _vgtContext.Examples.First(x => x.Id == entity.Id);
        efEntity.Sentence = entity.Sentence;
        efEntity.VocabId = entity.VocabId;
    }
}