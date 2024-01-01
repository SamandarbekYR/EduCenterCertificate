using EduCenter.DataAccess.Data;
using EduCenter.DataAccess.Interfaces;
using EduCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduCenter.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public DbSet<TEntity> _dbSet;

        public Repository(AppDb app)
        {
            this._dbSet = app.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public void Delete(TEntity entity, Guid id) => _dbSet.Remove(entity);
        public IEnumerable<TEntity> GetAll() => _dbSet;
        public TEntity GetById(Guid id) => _dbSet.FirstOrDefault(x => x.Id == id)!;
        public void Update(TEntity entity, Guid id) => _dbSet.Update(entity);

    }
}
