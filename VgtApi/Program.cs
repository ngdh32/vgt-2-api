var builder = WebApplication.CreateBuilder(args);

InitInfra.InitService(builder.Services, builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
