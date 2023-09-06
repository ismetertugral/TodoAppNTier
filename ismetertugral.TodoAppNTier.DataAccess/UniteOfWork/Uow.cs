using ismetertugral.TodoAppNTier.DataAccess.Contexts;
using ismetertugral.TodoAppNTier.DataAccess.Interfaces;
using ismetertugral.TodoAppNTier.DataAccess.Repositories;
using ismetertugral.TodoAppNTier.Entities.Domains;

namespace ismetertugral.TodoAppNTier.DataAccess.UniteOfWork
{
    public class Uow : IUow
    {
        private readonly TodoContext _context;

        public Uow(TodoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
