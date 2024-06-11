using Dummy.Core.Interfaces.Repositories.Base;
using Dummy.Core.Models;

namespace Dummy.Core.Interfaces.Repositories.Commands;

public interface ICommandUserRepository : IBaseCommandRepository<UserModel, int>
{
}