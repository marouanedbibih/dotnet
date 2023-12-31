using backend.Core.Enums;

namespace backend.Core.Dtos.Company
{
    public class CompanyGetDto
    {
        public long id { get; set; }
        public string name { get; set; }
        public CompanySize size { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;

        public bool isActive { get; set; } = true;
    }
}
