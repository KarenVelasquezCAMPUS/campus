using System.Reflection;
using API.Extensions;
using API.Helpers.JWT;
using AspNetCoreRateLimit;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAplicacionServices();
builder.Services.ConfigureRateLimit();
builder.Services.ConfigureApiVersioning();
// Learn more about configuring Swagger/OpenApiPushUpEnviaBackend at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureCors();
builder.Services.AddAplicacionServices();
builder.Services.AddJwt(builder.Configuration);

builder.Services.AddDbContext<ApiPushUpEnviaBackend>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("ConexMysql");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	var loggerFactory = services.GetRequiredService<ILoggerFactory>();
	try
	{
		var context = services.GetRequiredService<ApiPushUpEnviaBackendContext>();
		await context.Database.MigrateAsync();
		await ApiContextSeed.SeedRolesAsync(context,loggerFactory);
		await ApiContextSeed.SeedAsync(context,loggerFactory);
	}
	catch (Exception ex)
	{
		var _logger = loggerFactory.CreateLogger<Program>();
		_logger.LogError(ex, "Ocurrio un error durante la migracion");
	}
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseIpRateLimiting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
