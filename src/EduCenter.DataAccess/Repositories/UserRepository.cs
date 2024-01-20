using EduCenter.DataAccess.Data;
using EduCenter.DataAccess.Interfaces;
using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EduCenter.DataAccess.Repositories;

public class UserRepository : Repository<User>, IUser
{
    public UserRepository(AppDb app) : base(app)
    { }
    public List<User?> Where(Expression<Func<User, bool>> expression)
    {
        try
        {
            var result = _dbSet.Where(expression).AsNoTracking().ToList();

            if (result is null)
                return new List<User?>();

            else
                return result!;
        }
        catch
        {
            return new List<User?>();
        }
    }
}
