public class EFUnitOfWork : IUnitOfWork
{
    private readonly VgtDbContext _vgtContext;

    private readonly IVocablistRepository _vocablistRepository;
    private readonly IVocabRepository _vocabRepository;
    private readonly IExampleRepository _exampleRepository;

    public EFUnitOfWork(VgtDbContext vgtContext){
        _vgtContext = vgtContext;
        _vocablistRepository = new EFVocablistRepository(_vgtContext);
        _vocabRepository = new EFVocabRepository(_vgtContext);
        _exampleRepository = new EFExampleRepository(_vgtContext);
    }

    public IVocablistRepository VocablistRepository => _vocablistRepository;
    public IVocabRepository VocabRepository => _vocabRepository;
    public IExampleRepository ExampleRepository => _exampleRepository;

    public void Save()
    {
        _vgtContext.SaveChanges();
    }
}