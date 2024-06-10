using MassTransit;
using System.Text.Json;

public class UserQueue : IConsumer<UserModel>
{
    public Task Consume(ConsumeContext<UserModel> context)
    {
        var user = context.Message;

        Console.WriteLine(JsonSerializer.Serialize(user));

        return Task.CompletedTask;
    }
}