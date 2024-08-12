using Ardalis.Specification;
using business_logic.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace business_logic.Specifications;

public static class VideoSpecs
{
    internal class ById : Specification<Video>
    {
        public ById(int id)
        {
            Query
                .Where(x => x.Id == id);
        }
    }
    internal class All : Specification<Video>
    {
        public All(int id)
        {
            Query.Include(x => x.Id == id);
        }
    }
    internal class ByIds : Specification<Video>
    {
        public ByIds(IEnumerable<int> ids)
        {
            Query
                .Where(x => ids.Contains(x.Id));
        }
    }
}