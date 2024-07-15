using Bussiness_Logic.DTOs;

namespace Bussiness_Logic.Interfaces;

public interface ILikeService
{
    Task<IEnumerable<VideoDto>> Get(string userId);
    void Add(CreateLikeModel likeModel);
    Task Remove(string userId);
}