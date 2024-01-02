using AutoMapper;
using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Services.DTOs;

namespace EduCenter.Services.Mapper
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<CreateSertificateDto, Sertifikate>().ReverseMap();
        }
    }
}
