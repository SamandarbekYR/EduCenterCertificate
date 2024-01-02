using AutoMapper;
using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Services.DTOs;
using EduCenter.Services.Interfaces;

namespace EduCenter.Services.Services
{
    public class SertificateService : ISertificateService
    {
        private IUnitOfWork _repos;
        private IMapper _mapper;

        public SertificateService(IUnitOfWork unitOf, IMapper mapper)
        {
            _repos = unitOf;
            _mapper = mapper;
        }
        public int Add(CreateSertificateDto certificate)
        {
            Sertifikate sertifikate = _mapper.Map<Sertifikate>(certificate);

            _repos.Sertificate.Add(sertifikate);
            int a = _repos.SaveChanges();

            return a;
        }
        public IEnumerable<Sertifikate> GetAll() => _repos.Sertificate.GetAll();

        public Sertifikate? GetById(string CandidateNo, string CertificateNo)
        {
            var sertifikate = _repos.Sertificate
                    .Where(s => s.CandidateNo == CandidateNo && s.CertificateNo == CertificateNo);

            if (sertifikate.Any())
            {
                return sertifikate.FirstOrDefault();
            }
            
            return null;
        }
    }
}
