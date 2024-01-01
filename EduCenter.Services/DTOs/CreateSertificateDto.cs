using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Services.DTOs
{
    public class CreateSertificateDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string CandidateNo { get; set; } = string.Empty;
        public string SertificateNo { get; set; } = string.Empty;
    }
}
