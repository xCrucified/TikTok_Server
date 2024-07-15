using business_logic.Interfaces;

namespace business_logic.Services;

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