using brasil_api.Interfaces;
using brasil_api.Mappings;
using brasil_api.Rest;
using brasil_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IAddressService, AddressService>();
builder.Services.AddSingleton<IBankService, BankService>();
builder.Services.AddSingleton<IBrasilApi, BasilApiRest>();

builder.Services.AddAutoMapper(typeof(AddressMapping));

builder.Services.AddAutoMapper(typeof(BankMappin));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
