public interface IBaseRepository<T> where T : BaseEntity
{
    public T Get(string id);
    public List<T> GetAll();
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(string id);
}