using Bussiness_Logic.DTOs;

namespace Bussiness_Logic.Interfaces;

public interface ICommentService
{
    Task<IEnumerable<CommentDto>> Get(int id);
    void Add(CreateCommentModel commentModel);
    Task Remove(int videoId);
}