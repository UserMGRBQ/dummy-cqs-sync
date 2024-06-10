using DummyConsumer.Consumers;
using MassTransit;

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

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
