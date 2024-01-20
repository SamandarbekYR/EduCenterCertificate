using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.DataAccess.Data
{
    public class AppDb : DbContext
    {
        public DbSet<Sertifikate> Srtifikates { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDb(DbContextOptions<AppDb> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }
    }
}
