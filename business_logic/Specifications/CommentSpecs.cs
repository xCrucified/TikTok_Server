using Ardalis.Specification;
using business_logic.Entities;

namespace business_logic.Specifications;

public static class CommentSpecs
{
    internal class ById : Specification<Comment>
    {
        public ById(int Id)
        {
            Query.Where(x => x.Id == Id);
        }
    }
}