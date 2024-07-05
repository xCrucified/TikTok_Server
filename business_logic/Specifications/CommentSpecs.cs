using Ardalis.Specification;
using Bussiness_Logic.Entities;

namespace Bussiness_Logic.Specifications;

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