using Dummy.Core.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Dummy.Persistence.Repositories.Base;

public class BaseCommandRepository<T, Tid>(DbContext context) : IBaseCommandRepository<T, Tid>
    where T : class
    where Tid : IEquatable<Tid>
{
    protected readonly DbContext Db = context ?? throw new ArgumentNullException("There has been an error while trying to create a connection.");
    protected readonly DbSet<T> DbSet = context.Set<T>();

    public async Task AddAsync(T entity)
    {
        await DbSet.AddAsync(entity);
        await Db.SaveChangesAsync();
    }

    public async Task RemoveAsync(T entity)
    {
        DbSet.Remove(entity);
        await Db.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        DbSet.Update(entity);
        await Db.SaveChangesAsync();
    }

    public async Task Commit()
    {
        await Db.SaveChangesAsync();
    }
}