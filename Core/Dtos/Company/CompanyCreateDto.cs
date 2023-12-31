using backend.Core.Enums;

namespace backend.Core.Dtos.Company
{
    public class CompanyCreateDto
    {
        public string name { get; set; }
        public CompanySize size { get; set; }
    }
}
