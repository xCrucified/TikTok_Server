using Bussiness_Logic.DTOs;
using Bussiness_Logic.Interfaces;

namespace Bussiness_Logic.Services;

public class CommentService : ICommentService
{
    public void Add(CreateCommentModel commentModel)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CommentDto>> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task Remove(int videoId)
    {
        throw new NotImplementedException();
    }
}