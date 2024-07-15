using Bussiness_Logic.DTOs;
using Bussiness_Logic.Interfaces;

namespace Bussiness_Logic.Services;

public class SaveService : ISaveService
{
    public void Add(CreateSaveModel saveModel)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<VideoDto>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task Remove(int id)
    {
        throw new NotImplementedException();
    }
}