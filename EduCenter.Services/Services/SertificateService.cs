using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Services.DTOs;
using EduCenter.Services.Interfaces;

namespace EduCenter.Services.Services
{
    public class SertificateService : ISertificateService
    {
        private IUnitOfWork _repos;

        public SertificateService(IUnitOfWork unitOf)
        {
            _repos = unitOf;
        }
        public int Add(CreateSertificateDto certificate)
        {
            Sertifikate sertifikate = new Sertifikate();
            sertifikate.FirstName = certificate.FirstName;
            sertifikate.LastName = certificate.LastName;
            sertifikate.SertificateNo = certificate.SertificateNo;
            sertifikate.CandidateNo = certificate.CandidateNo;
            _repos.Sertificate.Add(sertifikate);
            int a =  _repos.SaveChanges();
        }
        public IEnumerable<Sertifikate> GetAll() => _repos.Sertificate.GetAll();
    }
}
