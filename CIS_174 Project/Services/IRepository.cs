namespace CIS_174_Project.Services
{
    using System.Linq;

    public interface IRepository<T> where T : class
    {
        IQueryable<T> List { get; }
        void Insert(T entity);
        void Delete(T entity);
        void Save();
    }
}
