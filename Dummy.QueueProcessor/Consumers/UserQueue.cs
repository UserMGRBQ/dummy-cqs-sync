using Dummy.Core.Interfaces.Repositories.Commands;
using Dummy.Core.Interfaces.Repositories.Queries;
using Dummy.Core.Models;
using MassTransit;
using System.Text.Json;

public class UserQueue(ICommandUserRepository command, IQueryUserRepository query) : IConsumer<UserModel>
{
    private readonly ICommandUserRepository _commandUserRepository = command;
    private readonly IQueryUserRepository _queryUserRepository = query;

    public Task Consume(ConsumeContext<UserModel> context)
    {
        var user = context.Message;

        var users = _commandUserRepository.GetAll();

        Console.WriteLine(JsonSerializer.Serialize(user));

        return Task.CompletedTask;
    }
}