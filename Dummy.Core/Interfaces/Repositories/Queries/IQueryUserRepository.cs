using Dummy.Core.Interfaces.Repositories.Base;
using Dummy.Core.Models;

namespace Dummy.Core.Interfaces.Repositories.Queries;

public interface IQueryUserRepository : IBaseQueryRepository<UserModel, int>
{
}