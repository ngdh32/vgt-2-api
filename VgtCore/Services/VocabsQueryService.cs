public class VocabsQueryService : IVocabsQueryService
{
    private readonly IUnitOfWork _unitOfWork;

    public VocabsQueryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public GetMemberVocablistsResponseDto GetMemberVocablists(GetMemberVocablistsRequestDto dto)
    {
        var vocablists = _unitOfWork.VocablistRepository.GetAll().Where(x => x.MemberId == dto.MemberId).ToList();
        var result = new List<VocablistBaseDto>();
        foreach(var vocablist in vocablists){
            var item = new VocablistBaseDto(vocablist.Id, vocablist.Name, vocablist.Language);
            result.Add(item);
        }

        return new GetMemberVocablistsResponseDto(result);
    }

    public GetVocablistResponseDto GetVocablist(GetVocablistRequestDto dto)
    {
        // var list = await _repo.GetVocablist(dto.VocablistId);
        // var result = _mapper.Map<VocablistViewDto>(list);
        // return new GetVocablistResponseDto(result);
        throw new NotImplementedException();
    }
}