using RBS.Application;
using RBS.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();   // Needed for Swagger
builder.Services.AddSwaggerGen();             // Adds Swagger generator

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                         // Generates Swagger JSON
    app.UseSwaggerUI();                       // Interactive Swagger UI
}

app.UseHttpsRedirection();
//app.UseAuthorization();
app.MapControllers();

app.Run();