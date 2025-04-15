namespace CIS_174_Project.Services
{
    using CIS_174_Project.Models.ToDoList;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly ToDoContext _context;
        private readonly DbSet<T> _dbSet;

        public EFRepository(ToDoContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> List => _dbSet;

        public void Insert(T entity) => _dbSet.Add(entity);

        public void Delete(T entity) => _dbSet.Remove(entity);

        public void Save() => _context.SaveChanges();
    }
}
