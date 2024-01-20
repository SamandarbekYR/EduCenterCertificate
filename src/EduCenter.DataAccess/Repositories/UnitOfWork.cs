using EduCenter.DataAccess.Data;
using EduCenter.DataAccess.Interfaces;
using EduCenter.Services.Interfaces;

namespace EduCenter.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public ISertificate Sertificate { get; set; }
        public IUser User { get ; set ; }

        private AppDb _dbSet;

        public UnitOfWork(AppDb app)
        {
            this._dbSet = app;
            this.Sertificate = new SertifcateRepository(app);
            this.User=new UserRepository(app);
        }
        public int SaveChanges()
        {
            int result = _dbSet.SaveChanges();
            return result;
        }

    }
}
