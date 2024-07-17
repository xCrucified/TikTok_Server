using Ardalis.Specification;
using business_logic.Entities;

namespace business_logic.Specifications;

public static class SaveSpecs
{
    internal class ById : Specification<Save>
    {
        private IEnumerable<int> ids;

        public ById(int Id)
        {
            Query.Where(x => x.Id == Id);
        }

        public ById(IEnumerable<int> ids)
        {
            this.ids = ids;
        }
    }
}