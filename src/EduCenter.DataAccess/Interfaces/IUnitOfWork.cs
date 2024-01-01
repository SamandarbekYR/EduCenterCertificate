using EduCenter.DataAccess.Interfaces;

namespace EduCenter.Services.Interfaces
{
    public interface IUnitOfWork
    {
        public ISertificate Sertificate { get; set; }
        public int SaveChanges();
    }
}
