using business_logic.DTOs;

namespace business_logic.Interfaces;

public interface ILikeService
{
    Task<IEnumerable<VideoDto>> Get(string userId);
    void Add(CreateLikeModel likeModel);
    Task Remove(string userId);
}