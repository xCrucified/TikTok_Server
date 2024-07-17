using Ardalis.Specification;
using business_logic.Entities;

namespace business_logic.Specifications;

public static class LikeSpecs
{
    internal class ById : Specification<Like>
    {
        public ById(int Id)
        {
            Query.Where(x => x.Id == x.Id);
        }
    }
}