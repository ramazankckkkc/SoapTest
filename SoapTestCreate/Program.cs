using SoapCore;
using System.ServiceModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSoapCore();
builder.Services.AddSingleton<ICalculator, CalculatorService>(); // Servis eklemek i�in

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseSoapEndpoint<ICalculator>("/calculatorService.asmx", new SoapEncoderOptions { });

app.UseAuthorization();

app.MapControllers();

app.Run();
