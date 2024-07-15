using Bussiness_Logic.DTOs;

namespace Bussiness_Logic.Interfaces;

public interface ISaveService
{
    Task<IEnumerable<VideoDto>> Get(IEnumerable<int> ids);
    void Add(CreateSaveModel saveModel);
    Task Remove(int id);
}