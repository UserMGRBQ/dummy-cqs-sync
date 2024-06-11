namespace Dummy.Core.Interfaces.Repositories.Base;

public interface IBaseQueryRepository<T, Tid>
    where T : class
    where Tid : IEquatable<Tid>
{
    Task<T> GetByIdAsync(Tid id);

    IQueryable<T> GetAll();

    Task Commit();
}