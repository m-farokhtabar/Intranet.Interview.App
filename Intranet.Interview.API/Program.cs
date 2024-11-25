using Intranet.Interview.API.StartupConfig;
using Intranet.Interview.Infrastructure.StartupConfig;
using Intranet.Interview.Application.StratupConfig;
using Intranet.Interview.Infrastructure.Data.ReadDb;
using Intranet.Interview.Infrastructure.DbProvider;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ApplicationConfiguration();
builder.Services.InfrastructureConfiguration(builder.Configuration["ConnectionStrings:DbConnection"]!, builder.Configuration["ConnectionStrings:MetaDbConnection"]!);

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
