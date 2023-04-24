using webapi.Middlewares;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Cada vez que se inyecte la interface se va crear un objeto helloword
// builder.Services.AddScoped<IHelloWorldService, HelloWordService >(); Buena practica

// builder.Services.AddScoped( p => new HelloWordService() );//Mala practica tendriamos que cambiarlo en cada dependencia
builder.Services.AddScoped<IHelloWorldService>( p => new HelloWordService() );



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// app.useTimeMiddleware();

app.MapControllers();

app.Run();
