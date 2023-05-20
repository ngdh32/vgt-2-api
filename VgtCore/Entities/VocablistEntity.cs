public class VocablistEntity : BaseEntity
{
    public LanguageType Language { get; set; }
    public string Name { get; set; }
    public List<VocabEntity> Vocabs { get; set; }
}