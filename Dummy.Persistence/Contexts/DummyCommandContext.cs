using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dummy.Persistence.Contexts;

public class DummyCommandContext(DbContextOptions<DummyCommandContext> opt) : DbContext(opt)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}