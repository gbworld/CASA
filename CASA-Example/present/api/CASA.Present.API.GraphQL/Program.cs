var builder = WebApplication.CreateBuilder(args);

// TODO: Add Schema here
builder.Services
    .AddGraphQLServer();


var app = builder.Build();

app.MapGraphQL();

app.Run();
