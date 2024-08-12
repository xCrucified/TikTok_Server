using Ardalis.Specification;
using business_logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace business_logic.Specifications
{
    public static class RefreshTokenSpecs
    {
        internal class ByToken : Specification<RefreshToken>
        {
            public ByToken(string value)
            {
                Query.Where(x => x.Token == value);
            }
        }
        internal class CreatedBy : Specification<RefreshToken>
        {
            public CreatedBy(DateTime date)
            {

                Query.Where(x => x.CreationDate < date);
            }
        }
    }
}
