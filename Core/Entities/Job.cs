using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Job : BaseEntity
    {
        public string title { get; set; }
        public JobLevel level { get; set; }

        // Relations
        public long companyId { get; set; }
        public Company company { get; set; }

        public ICollection<Candidate> candidates { get; set; }
    }
}
