public class VocabEntity : BaseEntity
{
    public string Word { get; set; }
    public string Definition { get; set; }
    public List<ExampleEntity> Examples { get; set; }
}