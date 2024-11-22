using Intranet.Interview.API.StartupConfig;
using Intranet.Interview.Infrastructure.StartupConfig;
using Intranet.Interview.Application.StratupConfig;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ApplicationSettings appSettings = builder.Configuration.GetSection("ApplicationSettings").Get<ApplicationSettings>()!;
builder.Services.AddSingleton<ApplicationSettings>(appSettings);

builder.Services.ApplicationConfiguration();
builder.Services.InfrastructureConfiguration(builder.Configuration["ConnectionStrings:DbConnection"]!);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCorsAllowAny();
app.UseAuthorization();

app.MapControllers();

app.Run();
