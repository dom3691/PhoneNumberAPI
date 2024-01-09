using PhoneNumber.Data;
using PhoneNumber.Domain.Interfaces.Data;
using PhoneNumber.Domain.Interfaces.Services;
using PhoneNumber.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPhoneInfoService, PhoneInfoService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<ICountryDetailService, CountryDetailService>();
builder.Services.AddTransient<ICountryRepository, CountryRepository>();
builder.Services.AddTransient<ICountryDetailsRepository, CountryDetailRepository>();

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
