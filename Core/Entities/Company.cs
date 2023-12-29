using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Company : BaseEntity
    {
        public string name { get; set; }
        public CompanySize size { get; set; }

        // Relations
        public ICollection<Job> jobs { get; set; }
    }
}
