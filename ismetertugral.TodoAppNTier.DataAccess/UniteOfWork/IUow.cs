using ismetertugral.TodoAppNTier.DataAccess.Interfaces;
using ismetertugral.TodoAppNTier.Entities.Domains;

namespace ismetertugral.TodoAppNTier.DataAccess.UniteOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T: BaseEntity;

        Task SaveChanges();
    }
}
