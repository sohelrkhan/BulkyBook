namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
    }
}
