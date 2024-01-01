using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Services.DTOs;

namespace EduCenter.Services.Interfaces
{
    public interface ISertificateService
    {
        int Add(CreateSertificateDto certificate);
        IEnumerable<Sertifikate> GetAll();
    }
}
