using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Domain.Entities.Sertifikat
{
    [Table("sertificate")]
    public class Sertifikate : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string CandidateNo {  get; set; } = string.Empty;
        public string CertificateNo {  get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string PlaseOfBirth { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string ExamCenter { get; set; } = string.Empty;
        public DateTime ExamDate { get; set; } 
        public float ReadingScore { get; set; }
        public float ListeningScore { get; set; }
        public float SpeakingScore { get; set; }
        public float WritingScore { get; set; }
        public float TotalScore { get; set; }
        public string Level { get; set; } = string.Empty;
        public string CertificateType {  get; set; } = string.Empty;
    }
}
