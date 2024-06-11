using Dummy.Core.Interfaces.Repositories.Queries;
using Dummy.Core.Models;
using Dummy.Persistence.Contexts;
using Dummy.Persistence.Repositories.Base;

namespace Dummy.Persistence.Repositories.Queries;

public class QueryUserRepository(DummyQueryContext context) : BaseQueryRepository<UserModel, int>(context), IQueryUserRepository
{
}