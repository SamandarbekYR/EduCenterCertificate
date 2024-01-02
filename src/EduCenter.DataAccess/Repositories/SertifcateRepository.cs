using EduCenter.DataAccess.Data;
using EduCenter.DataAccess.Interfaces;
using EduCenter.Domain.Entities.Sertifikat;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EduCenter.DataAccess.Repositories
{
    public class SertifcateRepository : Repository<Sertifikate>, ISertificate
    {
        public SertifcateRepository(AppDb app) : base(app)
        { }

        public List<Sertifikate?> Where(Expression<Func<Sertifikate, bool>> expression)
        {

            try
            {
                var result = _dbSet.Where(expression).AsNoTracking().ToList();

                if (result is null)
                    return new List<Sertifikate?>();

                else
                    return result!;
            }
            catch
            {
                return new List<Sertifikate?>();
            }
        }
    }
}
