using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Entities
{
    public class Save
    {
        public int Id { get; set; }
        public DateTime DateSave { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Video> Videos { get; set; }
    }
}
