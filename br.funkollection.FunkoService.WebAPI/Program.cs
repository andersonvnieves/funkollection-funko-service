using br.funkollection.FunkoService.Domain.Queries.GetFunkoById;
using br.funkollection.FunkoService.Domain.Entities;
using MediatR;
using br.funkollection.FunkoService.Domain.Repositories;
using br.funkollection.FunkoService.Infrastructure.InMemoryRepositories;
using br.funkollection.FunkoService.Domain.Queries.GetFunkos;
using br.funkollection.FunkoService.Domain.Commands.PostFunko;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Funko).Assembly));

//Add Repositories
builder.Services.AddSingleton<IFunkoRepository<Funko>, FunkoRepository>();
builder.Services.AddSingleton<ICategoryRepository<Category>, CategoryRepository>();
builder.Services.AddSingleton<ISerieRepository<Serie>, SerieRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/funko", (IMediator mediator) => mediator.Send(new GetFunkosRequest()))
.WithName("GetFunkos")
.WithOpenApi();

app.MapGet("/funko/{id}", (IMediator mediator, Guid id) => mediator.Send(new GetFunkoByIdRequest(id)))
.WithName("GetFunkoById")
.WithOpenApi();

app.MapPost("/funko", (IMediator mediator, PostFunkoRequest request) => mediator.Send(request))
.WithName("PostFunko")
.WithOpenApi();

app.MapPut("/funko", (IMediator mediator) => mediator.Send(""))
.WithName("PutFunko")
.WithOpenApi();

app.MapDelete("/funko/{id}", (IMediator mediator, Guid id) => mediator.Send(""))
.WithName("DeleteFunko")
.WithOpenApi();

app.MapGet("/serie", (IMediator mediator) => mediator.Send(""))
.WithName("GetSeries")
.WithOpenApi();

app.MapGet("/category", (IMediator mediator) => mediator.Send(""))
.WithName("GetCategories")
.WithOpenApi();

app.Run();
