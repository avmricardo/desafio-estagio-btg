using app.DI;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(7085);
});

builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "DesafioBTG",
        Description = "API do DesafioBTG"
    });
});

builder.Services.AddConfigServices(builder.Configuration);

builder.Services.AddConfigRepositories();

builder.Services.AddContexto(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors("AllowAllOrigins");

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
