using Ardalis.Specification;
using business_logic.Entities;

namespace business_logic.Specifications;

public static class SaveSpecs
{
    internal class ById : Specification<Save>
    {
        public ById(int Id)
        {
            Query.Where(x => x.Id == Id);
        }
    }
}