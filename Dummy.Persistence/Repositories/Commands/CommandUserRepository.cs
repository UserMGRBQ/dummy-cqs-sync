using Dummy.Core.Interfaces.Repositories.Commands;
using Dummy.Core.Models;
using Dummy.Persistence.Contexts;
using Dummy.Persistence.Repositories.Base;

namespace Dummy.Persistence.Repositories.Commands;

public class CommandUserRepository(DummyCommandContext context) : BaseCommandRepository<UserModel, int>(context), ICommandUserRepository
{
}