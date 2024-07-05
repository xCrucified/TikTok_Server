using Ardalis.Specification;
using Bussiness_Logic.Entities;

namespace Bussiness_Logic.Specifications;

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