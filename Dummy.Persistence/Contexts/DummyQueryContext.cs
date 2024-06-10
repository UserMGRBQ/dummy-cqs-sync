using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dummy.Persistence.Contexts;

public class DummyQueryContext(DbContextOptions<DummyQueryContext> opt) : DbContext(opt)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}