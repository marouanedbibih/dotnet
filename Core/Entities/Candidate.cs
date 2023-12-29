namespace backend.Core.Entities
{
    public class Candidate : BaseEntity
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string coverLetter { get; set; }
        public string resumeUrl { get; set; }

        // Relations

        public long jobId { get; set; }
        public Job job { get; set; }
    }
}
