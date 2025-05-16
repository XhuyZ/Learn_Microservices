using Ocelot.DependencyInjection;
using Ocelot.Middleware;
var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot();
builder.Services.AddCors(options => 
    {
    options.AddDefaultPolicy(builder =>
        {

        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        });
    });

var app = builder.Build();
app.UseCors();
app.UseHttpsRedirection();
app.UseOcelot().Wait();
app.Run();


