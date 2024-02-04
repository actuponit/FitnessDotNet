using FitnessDotNet.Controllers;
using FitnessDotNet.DBConfig;

var builder = WebApplication.CreateBuilder(args);
var DBConfig = builder.Configuration.GetSection("MongoDBSettings");


// Add services to the container.
builder.Services.AddScoped<ISample, SampleService>();
// Database Cofiguration
builder.Services.Configure<MongoDBSettings>(DBConfig);

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

app.UseAuthorization();

app.MapControllers();

app.Run();
