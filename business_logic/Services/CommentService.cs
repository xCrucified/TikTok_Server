using business_logic.Interfaces;

namespace business_logic.Services;

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