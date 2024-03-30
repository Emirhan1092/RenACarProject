using Autofac;
using Autofac.Extensions.DependencyInjection;
using Buisness.DependencyResolves.Autofac;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBuisnessModule());        //�lerleyen zamanda autofacten ba�ka yap�ya ge�eceksek dependency alt�na kendi yap�m�z� kurup,
});                                                             //AutafacServiceProviderFactory() ve AutofacBussinessModule() k�sm�n� de�i�tirmemiz yeterli

// Add services to the container.

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
app.Run();