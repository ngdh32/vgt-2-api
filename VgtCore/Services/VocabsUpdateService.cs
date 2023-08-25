public class VocabsUpdateService : IVocabsUpdateService
{
    private readonly IUnitOfWork _unitOfWork;

    public VocabsUpdateService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    

    // public ResponseDto UpdateVocablist(UpdateVocablistRequestDto dto)
    // {
    //     throw new NotImplementedException();
    // }

    public ResponseDto InsertVocablist(InsertVocablistRequestDto dto)
    {
        var entity = new VocablistEntity(){
            Name = dto.Name,
            MemberId = dto.MemberId,
            Language = dto.language
        };
        _unitOfWork.VocablistRepository.Add(entity);

        _unitOfWork.Save();

        return new ResponseDto(ErrorCodeType.Success);
    }

    // public ResponseDto DeleteVocablist(DeleteVocablistRequestDto dto)
    // {
    //     throw new NotImplementedException();
    // }
}