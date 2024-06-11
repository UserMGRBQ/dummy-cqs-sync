namespace Dummy.Core.Interfaces.Repositories.Base;

public interface IBaseQueryRepository<T, Tid>
    where T : class
    where Tid : IEquatable<Tid>
{
    Task<T> GetByIdAsync(Tid id);

    IQueryable<T> GetAll();

    Task AddAsync(T entity);

    Task RemoveAsync(T entity);

    Task UpdateAsync(T entity);

    Task Commit();
}