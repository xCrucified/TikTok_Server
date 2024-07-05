using Ardalis.Specification;
using Bussiness_Logic.Entities;

namespace Bussiness_Logic.Specifications;

public static class LikeSpecs
{
    internal class ById : Specification<Like>
    {
        public ById(int Id)
        {
            Query.Where(x => x.Id == Id);
        }
    }
}