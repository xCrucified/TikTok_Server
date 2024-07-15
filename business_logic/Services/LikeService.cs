using Bussiness_Logic.DTOs;
using Bussiness_Logic.Interfaces;

namespace Bussiness_Logic.Services;

public class LikeService : ILikeService
{
    public void Add(CreateLikeModel likeModel)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<VideoDto>> Get(string userId)
    {
        throw new NotImplementedException();
    }

    public Task Remove(string userId)
    {
        throw new NotImplementedException();
    }
}