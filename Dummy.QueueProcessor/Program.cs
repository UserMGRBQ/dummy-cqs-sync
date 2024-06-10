using MassTransit;
using Dummy.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<UserQueue>();

    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", 1572, "/", h => {
            h.Username("admin");
            h.Password("admin");
        });

        cfg.ConfigureEndpoints(context);
    });
});

builder.Services.AddDummyPersistence();

var app = builder.Build();

app.MapGet("/", () => "Synchronizing databases...");

app.Run();
