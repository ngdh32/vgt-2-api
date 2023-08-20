public record GetMemberVocablistsRequestDto(string MemberId);
public record GetMemberVocablistsResponseDto(List<VocablistBaseDto> Vocablists);
public record GetVocablistRequestDto(string VocablistId);
public record GetVocablistResponseDto(VocablistViewDto Vocablist);
public record GetVocabRequestDto();
public record GetVocabResponseDto();

public abstract record BaseViewDto(string Id);
public record VocablistBaseDto(string Id, string Name, LanguageType Language) : BaseViewDto(Id);
public record VocablistViewDto(string Id, string Name, LanguageType Language , List<VocabViewDto> Vocabs) : VocablistBaseDto(Id, Name, Language);
public record VocabViewDto(string Id, string Word, string Definition, List<ExampleViewDto> Examples) : BaseViewDto(Id);
public record ExampleViewDto(string Id, string Sentence) : BaseViewDto(Id);