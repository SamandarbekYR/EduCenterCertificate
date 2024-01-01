using EduCenter.DataAccess.Data;
using EduCenter.DataAccess.Interfaces;
using EduCenter.Domain.Entities.Sertifikat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.DataAccess.Repositories
{
    public class SertifcateRepository : Repository<Sertifikate>, ISertificate
    {
        public SertifcateRepository(AppDb app) : base(app)
        { }
    }
}
