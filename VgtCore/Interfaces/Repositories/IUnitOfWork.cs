public interface IUnitOfWork
{
    IVocablistRepository VocablistRepository { get; }
    IVocabRepository VocabRepository { get; }
    IExampleRepository ExampleRepository { get; }
    void Save();
}