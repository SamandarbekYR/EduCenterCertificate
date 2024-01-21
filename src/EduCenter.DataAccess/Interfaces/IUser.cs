using EduCenter.Domain.Entities.Sertifikat;
using EduCenter.Domain.Entities.User;
using System.Linq.Expressions;

namespace EduCenter.DataAccess.Interfaces;

public interface IUser : IRepository<User>
{
    public List<User?> Where(Expression<Func<User, bool>> expression);
    public User GetByPhone(string phone);
}
