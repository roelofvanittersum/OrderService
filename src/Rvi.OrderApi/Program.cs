using Rvi.OrderApi.Database;
using Rvi.OrderApi.Domain.Database;
using Rvi.OrderApi.Domain.Services;
using Rvi.OrderApi.Middleware;
using Rvi.OrderApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add logging service
builder.Services.AddLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

builder.Services.AddScoped<ILogger>();

builder.Services.AddOptions<MongoDatabaseSettings>().Bind(builder.Configuration.GetSection(nameof(MongoDatabaseSettings)));

builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderDataService, OrderDataService>();
builder.Services.AddScoped<Rvi.OrderApi.Domain.Database.IQueueDataService, QueueDataService>();

// Add Worker Service
builder.Services.AddHostedService<OrderCreatedConsumer>();

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseHttpLogging();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionMiddleware>();

app.Run();