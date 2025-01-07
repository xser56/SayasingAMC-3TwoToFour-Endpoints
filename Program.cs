using SayasingAMC_3TwoToFour_Endpoints.Controllers;
using SayasingAMC_3TwoToFour_Endpoints.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add Three Services Here
builder.Services.AddScoped<AddTwoNumbersServices>();
builder.Services.AddScoped<GreaterThenOrLessThenservices>();
builder.Services.AddScoped<WhoAreYouServices>();

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
