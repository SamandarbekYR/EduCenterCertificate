using EduCenter.Domain.Entities.Sertifikat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.DataAccess.Interfaces
{
    public interface ISertificate : IRepository<Sertifikate>
    {
        public List<Sertifikate?> Where(Expression<Func<Sertifikate, bool>> expression);
    }
}
