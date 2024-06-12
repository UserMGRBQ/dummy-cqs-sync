using Dummy.Core.Interfaces.Repositories.Commands;
using Dummy.Core.Interfaces.Repositories.Queries;
using Dummy.Core.Models;
using MassTransit;

namespace Dummy.QueueProcessor.Consumers;

public class UserQueue(ICommandUserRepository command, IQueryUserRepository query) : IConsumer<UserModel>
{
    private readonly ICommandUserRepository _commandUserRepository = command;
    private readonly IQueryUserRepository _queryUserRepository = query;

    public async Task Consume(ConsumeContext<UserModel> context)
    {
        try
        {
            await _queryUserRepository.AddAsync(context.Message);
        }
        catch (Exception)
        {
            throw;
        }
    }
}