using EduCenter.Services.DTOs;
using EduCenter.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCenter.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SertificateController : ControllerBase
    {
        private readonly ISertificateService _service;

        public SertificateController(ISertificateService service)
        {
            _service = service;
        }
        
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult GetAll()
         => Ok(_service.GetAll());

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CreateSertificateDto dto)
         => Ok(_service.Add(dto));

        [HttpGet("getby")]
        [Authorize(Roles = "Admin")]
        public  IActionResult GetBy(string CandidateNo, string CertificateNo)
        {
           return Ok( _service.GetById(CandidateNo, CertificateNo));
        }
        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(Guid id)
        {
           return Ok(_service.Delete(id));
        }
    }
}
