using business_logic.DTOs;

namespace business_logic.Interfaces;

public interface ICommentService
{
    Task<IEnumerable<CommentDto>> Get(int id);
    void Add(CreateCommentModel commentModel);
    Task Remove(int id);
}