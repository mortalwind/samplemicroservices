using ContactService.Core.Abstract;
using ContactService.Core.Contracts;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
var dbConfig = builder.Configuration.GetSection("DatabaseSettings");
// Add services to the container.
// requires using Microsoft.Extensions.Options
builder.Services.Configure<DatabaseSettings>(dbConfig);

builder.Services.AddSingleton<IDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);
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

app.UseAuthorization();

app.MapControllers();

app.Run();
